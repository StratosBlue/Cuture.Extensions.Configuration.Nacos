// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: nacos_grpc_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Nacos.Grpc.GrpcService {

  /// <summary>Holder for reflection information generated from nacos_grpc_service.proto</summary>
  public static partial class NacosGrpcServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for nacos_grpc_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NacosGrpcServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9uYWNvc19ncnBjX3NlcnZpY2Vfb3JpZ2luLnByb3RvGhlnb29nbGUvcHJv",
            "dG9idWYvYW55LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnBy",
            "b3RvIoMBCghNZXRhZGF0YRIMCgR0eXBlGAMgASgJEhAKCGNsaWVudElwGAgg",
            "ASgJEicKB2hlYWRlcnMYByADKAsyFi5NZXRhZGF0YS5IZWFkZXJzRW50cnka",
            "LgoMSGVhZGVyc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToC",
            "OAEiSgoHUGF5bG9hZBIbCghtZXRhZGF0YRgCIAEoCzIJLk1ldGFkYXRhEiIK",
            "BGJvZHkYAyABKAsyFC5nb29nbGUucHJvdG9idWYuQW55MjgKDVJlcXVlc3RT",
            "dHJlYW0SJwoNcmVxdWVzdFN0cmVhbRIILlBheWxvYWQaCC5QYXlsb2FkIgAw",
            "ATIqCgdSZXF1ZXN0Eh8KB3JlcXVlc3QSCC5QYXlsb2FkGgguUGF5bG9hZCIA",
            "Mj4KD0JpUmVxdWVzdFN0cmVhbRIrCg9yZXF1ZXN0QmlTdHJlYW0SCC5QYXls",
            "b2FkGgguUGF5bG9hZCIAKAEwAUIIqgIFTmFjb3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Nacos.Grpc.GrpcService.Metadata), global::Nacos.Grpc.GrpcService.Metadata.Parser, new[]{ "Type", "ClientIp", "Headers" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Nacos.Grpc.GrpcService.Payload), global::Nacos.Grpc.GrpcService.Payload.Parser, new[]{ "Metadata", "Body" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Metadata : pb::IMessage<Metadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Metadata> _parser = new pb::MessageParser<Metadata>(() => new Metadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Metadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Nacos.Grpc.GrpcService.NacosGrpcServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Metadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Metadata(Metadata other) : this() {
      type_ = other.type_;
      clientIp_ = other.clientIp_;
      headers_ = other.headers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Metadata Clone() {
      return new Metadata(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clientIp" field.</summary>
    public const int ClientIpFieldNumber = 8;
    private string clientIp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientIp {
      get { return clientIp_; }
      set {
        clientIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "headers" field.</summary>
    public const int HeadersFieldNumber = 7;
    private static readonly pbc::MapField<string, string>.Codec _map_headers_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 58);
    private readonly pbc::MapField<string, string> headers_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Headers {
      get { return headers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Metadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Metadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (ClientIp != other.ClientIp) return false;
      if (!Headers.Equals(other.Headers)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (ClientIp.Length != 0) hash ^= ClientIp.GetHashCode();
      hash ^= Headers.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      headers_.WriteTo(output, _map_headers_codec);
      if (ClientIp.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ClientIp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      headers_.WriteTo(ref output, _map_headers_codec);
      if (ClientIp.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ClientIp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (ClientIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientIp);
      }
      size += headers_.CalculateSize(_map_headers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Metadata other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.ClientIp.Length != 0) {
        ClientIp = other.ClientIp;
      }
      headers_.MergeFrom(other.headers_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 58: {
            headers_.AddEntriesFrom(input, _map_headers_codec);
            break;
          }
          case 66: {
            ClientIp = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 58: {
            headers_.AddEntriesFrom(ref input, _map_headers_codec);
            break;
          }
          case 66: {
            ClientIp = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Payload : pb::IMessage<Payload>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Payload> _parser = new pb::MessageParser<Payload>(() => new Payload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Payload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Nacos.Grpc.GrpcService.NacosGrpcServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Payload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Payload(Payload other) : this() {
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      body_ = other.body_ != null ? other.body_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Payload Clone() {
      return new Payload(this);
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private global::Nacos.Grpc.GrpcService.Metadata metadata_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Nacos.Grpc.GrpcService.Metadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Any body_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any Body {
      get { return body_; }
      set {
        body_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Payload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Payload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (!object.Equals(Body, other.Body)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (body_ != null) hash ^= Body.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (body_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (body_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (body_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Body);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Payload other) {
      if (other == null) {
        return;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Nacos.Grpc.GrpcService.Metadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      if (other.body_ != null) {
        if (body_ == null) {
          Body = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Body.MergeFrom(other.Body);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            if (metadata_ == null) {
              Metadata = new global::Nacos.Grpc.GrpcService.Metadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 26: {
            if (body_ == null) {
              Body = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Body);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            if (metadata_ == null) {
              Metadata = new global::Nacos.Grpc.GrpcService.Metadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 26: {
            if (body_ == null) {
              Body = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Body);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
