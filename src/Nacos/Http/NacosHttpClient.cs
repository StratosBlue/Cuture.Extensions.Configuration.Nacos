﻿using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Nacos.Exceptions;
using Nacos.Http.Messages;

namespace Nacos.Http;

/// <inheritdoc cref="INacosClient"/>
public abstract class NacosHttpClient : INacosClient
{
    #region Private 字段

    private readonly IAccessTokenService _accessTokenService;
    private readonly INacosUnderlyingHttpClientFactory _httpClientFactory;
    private readonly string _name;
    private readonly INacosRequestSigner _requestSigner;
    private readonly CancellationTokenSource _runningTokenSource;
    private readonly IServerAddressAccessor _serverAddressAccessor;
    private bool _disposedValue;
    private bool _isInitiated;

    #endregion Private 字段

    #region Protected 属性

    /// <inheritdoc/>
    public NacosClientType Type => NacosClientType.Http;

    /// <summary>
    /// Logger
    /// </summary>
    protected ILogger? Logger { get; }

    /// <summary>
    /// 客户端是否在运行的Token
    /// </summary>
    protected CancellationToken RunningToken { get; }

    #endregion Protected 属性

    #region Public 构造函数

    /// <inheritdoc cref="NacosHttpClient"/>
    public NacosHttpClient(NacosHttpClientOptions clientOptions)
    {
        if (clientOptions is null)
        {
            throw new ArgumentNullException(nameof(clientOptions));
        }

        Logger = clientOptions.LoggerFactory?.CreateLogger(GetType());

        _name = clientOptions.ClientName;

        _serverAddressAccessor = clientOptions.ServerAddressAccessor;

        _httpClientFactory = clientOptions.HttpClientFactory;

        _accessTokenService = clientOptions.User is null
                                    ? new NoneAccessTokenService()
                                    : new AccessTokenService(clientOptions.User, _serverAddressAccessor, _httpClientFactory, clientOptions.LoggerFactory);

        _requestSigner = clientOptions.AcsProfile is null
                                ? new NullRequestSigner()
                                : new ACMRequestSigner(clientOptions.AcsProfile.AccessKeyId, clientOptions.AcsProfile.AccessKeySecret);

        _runningTokenSource = new();
        RunningToken = _runningTokenSource.Token;
    }

    #endregion Public 构造函数

    #region Public 方法

    /// <inheritdoc/>
    public virtual async Task InitAsync()
    {
        CheckDisposed();

        if (_isInitiated)
        {
            return;
        }

        try
        {
            await _serverAddressAccessor.InitAsync(RunningToken).ConfigureAwait(false);

            await _accessTokenService.InitAsync().ConfigureAwait(false);

            _isInitiated = true;
        }
        catch (Exception ex)
        {
            await DisposeAsync().ConfigureAwait(false);
            throw new NacosException("初始化客户端异常", ex);
        }
    }

    #endregion Public 方法

    #region Protected 方法

    #region ExecuteRequest

    /// <summary>
    /// 发送请求
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    /// <param name="request"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    protected async Task<TResponse?> RequestAsync<TResponse>(NacosHttpRequest request, CancellationToken token) where TResponse : NacosHttpResponse
    {
        var response = await RequestAsync(request, token).ConfigureAwait(false);

        //HACK 硬编码反序列化方式？
        return JsonSerializer.Deserialize<TResponse>(response ?? string.Empty);
    }

    /// <inheritdoc cref="RequestAsync{TResponse}(NacosHttpRequest, CancellationToken)"/>
    protected async Task<string?> RequestAsync(NacosHttpRequest request, CancellationToken token)
    {
        CheckDisposed();
        CheckInitiated();

        HttpResponseMessage? response = null;
        bool isAccessTokenRefreshed = false;

        for (int i = 0; i < _serverAddressAccessor.Count || i < 3; i++)
        {
            var server = _serverAddressAccessor.CurrentAddress;
            try
            {
                await _requestSigner.SignAsync(request).ConfigureAwait(false);

                Logger?.LogDebug("执行请求 {Request} - TargetServer: {Server}", request, server);

                using var client = _httpClientFactory.CreateClient(server.HttpUri);

                using var httpRequest = request.ToHttpRequestMessage(server);

                PrepareRequest(httpRequest);

                response = await client.SendAsync(httpRequest, cancellationToken: token).ConfigureAwait(false);

                Logger?.LogDebug("Server: {Server} , 请求 {Request} 响应 - Code: {StatusCode} ", server, request, response.StatusCode);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await response.Content.ReadAsStringAsync(token).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                token.ThrowIfCancellationRequested();

                Logger?.LogError(ex, "请求执行失败 {Request} - TargetServer: {Server}", request, server);

                _serverAddressAccessor.MoveNextAddress();

                continue;
            }

            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                //访问受限，尝试刷新一次Token
                if (!isAccessTokenRefreshed)
                {
                    await _accessTokenService.RefreshAccessTokenAsync().ConfigureAwait(false);
                    isAccessTokenRefreshed = true;
                }
                else
                {
                    throw new ForbiddenException($"访问被禁止 - Request: {request} Response: {response}");
                }
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new HttpRequestNotFoundException("无法找到资源", request);
            }
            else
            {
                Logger?.LogError("请求未正确返回 - Request: {Request} - 响应Code: {StatusCode} - TargetServer: {Server}", request, response.StatusCode, server);
            }
        }

        throw new NacosException($"请求Nacos失败 - 已尝试所有服务地址 Request: {request}");
    }

    #endregion ExecuteRequest

    /// <summary>
    /// 检查是否已释放
    /// </summary>
    protected virtual void CheckDisposed()
    {
        if (_disposedValue)
        {
            throw new ObjectDisposedException(nameof(NacosHttpClient));
        }
    }

    /// <summary>
    /// 检查是否未初始化
    /// </summary>
    protected virtual void CheckInitiated()
    {
        if (!_isInitiated)
        {
            throw new NacosException("使用Client前应该先初始化");
        }
    }

    #endregion Protected 方法

    #region Private 方法

    private void PrepareRequest(HttpRequestMessage httpRequest)
    {
        var uriBuilder = new UriBuilder(httpRequest.RequestUri!);

        var queryBuilder = new StringBuilder(uriBuilder.Query, 512);

        var accessToken = _accessTokenService.AccessToken;

        if (!string.IsNullOrWhiteSpace(accessToken))
        {
            if (queryBuilder.Length == 0)
            {
                queryBuilder.Append('?');
            }
            else
            {
                queryBuilder.Append('&');
            }
            queryBuilder.Append($"{Constants.Headers.ACCESS_TOKEN}={accessToken}");
        }

        uriBuilder.Query = queryBuilder.ToString();

        httpRequest.RequestUri = uriBuilder.Uri;
    }

    #endregion Private 方法

    #region Dispose

    /// <summary>
    ///
    /// </summary>
    ~NacosHttpClient()
    {
        Dispose(true);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc/>
    public ValueTask DisposeAsync()
    {
        Dispose(true);
        return new ValueTask();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="disposing"></param>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            _disposedValue = true;

            _runningTokenSource.SilenceRelease();
        }
    }

    #endregion Dispose
}
