// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: obj/Debug/CWashExecutionService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1 {

  /// <summary>Holder for reflection information generated from obj/Debug/CWashExecutionService.proto</summary>
  public static partial class CWashExecutionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for obj/Debug/CWashExecutionService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CWashExecutionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVvYmovRGVidWcvQ1dhc2hFeGVjdXRpb25TZXJ2aWNlLnByb3RvEjRzaWxh",
            "Mi5jeXRlbmEuY3dhc2guZmVhdHVyZXMuY3dhc2hleGVjdXRpb25zZXJ2aWNl",
            "LnYxGhNTaUxBRnJhbWV3b3JrLnByb3RvIqMDChhEYXRhVHlwZV9Db21tYW5k",
            "UmVzcG9uc2USfgoPQ29tbWFuZFJlc3BvbnNlGAEgASgLMmUuc2lsYTIuY3l0",
            "ZW5hLmN3YXNoLmZlYXR1cmVzLmN3YXNoZXhlY3V0aW9uc2VydmljZS52MS5E",
            "YXRhVHlwZV9Db21tYW5kUmVzcG9uc2UuQ29tbWFuZFJlc3BvbnNlX1N0cnVj",
            "dBqGAgoWQ29tbWFuZFJlc3BvbnNlX1N0cnVjdBIzCgtDb21tYW5kTmFtZRgB",
            "IAEoCzIeLnNpbGEyLm9yZy5zaWxhc3RhbmRhcmQuU3RyaW5nEjgKEEZpcm13",
            "YXJlUmVzcG9uc2UYAiABKAsyHi5zaWxhMi5vcmcuc2lsYXN0YW5kYXJkLlN0",
            "cmluZxI9ChJFeGVjdXRpb25TdGFydGVkQXQYAyABKAsyIS5zaWxhMi5vcmcu",
            "c2lsYXN0YW5kYXJkLlRpbWVzdGFtcBI+ChNFeGVjdXRpb25GaW5pc2hlZEF0",
            "GAQgASgLMiEuc2lsYTIub3JnLnNpbGFzdGFuZGFyZC5UaW1lc3RhbXAiTAoZ",
            "RXhlY3V0ZUNvbW1hbmRfUGFyYW1ldGVycxIvCgdDb21tYW5kGAEgASgLMh4u",
            "c2lsYTIub3JnLnNpbGFzdGFuZGFyZC5CaW5hcnkigwEKGEV4ZWN1dGVDb21t",
            "YW5kX1Jlc3BvbnNlcxJnCg9Db21tYW5kUmVzcG9uc2UYASABKAsyTi5zaWxh",
            "Mi5jeXRlbmEuY3dhc2guZmVhdHVyZXMuY3dhc2hleGVjdXRpb25zZXJ2aWNl",
            "LnYxLkRhdGFUeXBlX0NvbW1hbmRSZXNwb25zZSJOChpFeGVjdXRlUHJvdG9j",
            "b2xfUGFyYW1ldGVycxIwCghQcm90b2NvbBgBIAEoCzIeLnNpbGEyLm9yZy5z",
            "aWxhc3RhbmRhcmQuQmluYXJ5IhsKGUV4ZWN1dGVQcm90b2NvbF9SZXNwb25z",
            "ZXMy7wQKFUNXYXNoRXhlY3V0aW9uU2VydmljZRKzAQoORXhlY3V0ZUNvbW1h",
            "bmQSTy5zaWxhMi5jeXRlbmEuY3dhc2guZmVhdHVyZXMuY3dhc2hleGVjdXRp",
            "b25zZXJ2aWNlLnYxLkV4ZWN1dGVDb21tYW5kX1BhcmFtZXRlcnMaTi5zaWxh",
            "Mi5jeXRlbmEuY3dhc2guZmVhdHVyZXMuY3dhc2hleGVjdXRpb25zZXJ2aWNl",
            "LnYxLkV4ZWN1dGVDb21tYW5kX1Jlc3BvbnNlcyIAEpIBCg9FeGVjdXRlUHJv",
            "dG9jb2wSUC5zaWxhMi5jeXRlbmEuY3dhc2guZmVhdHVyZXMuY3dhc2hleGVj",
            "dXRpb25zZXJ2aWNlLnYxLkV4ZWN1dGVQcm90b2NvbF9QYXJhbWV0ZXJzGisu",
            "c2lsYTIub3JnLnNpbGFzdGFuZGFyZC5Db21tYW5kQ29uZmlybWF0aW9uIgAS",
            "bwoURXhlY3V0ZVByb3RvY29sX0luZm8SLC5zaWxhMi5vcmcuc2lsYXN0YW5k",
            "YXJkLkNvbW1hbmRFeGVjdXRpb25VVUlEGiUuc2lsYTIub3JnLnNpbGFzdGFu",
            "ZGFyZC5FeGVjdXRpb25JbmZvIgAwARKZAQoWRXhlY3V0ZVByb3RvY29sX1Jl",
            "c3VsdBIsLnNpbGEyLm9yZy5zaWxhc3RhbmRhcmQuQ29tbWFuZEV4ZWN1dGlv",
            "blVVSUQaTy5zaWxhMi5jeXRlbmEuY3dhc2guZmVhdHVyZXMuY3dhc2hleGVj",
            "dXRpb25zZXJ2aWNlLnYxLkV4ZWN1dGVQcm90b2NvbF9SZXNwb25zZXMiAGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Sila2.Org.Silastandard.SiLAFrameworkReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse), global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Parser, new[]{ "CommandResponse" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Types.CommandResponse_Struct), global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Types.CommandResponse_Struct.Parser, new[]{ "CommandName", "FirmwareResponse", "ExecutionStartedAt", "ExecutionFinishedAt" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteCommand_Parameters), global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteCommand_Parameters.Parser, new[]{ "Command" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteCommand_Responses), global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteCommand_Responses.Parser, new[]{ "CommandResponse" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteProtocol_Parameters), global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteProtocol_Parameters.Parser, new[]{ "Protocol" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteProtocol_Responses), global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.ExecuteProtocol_Responses.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DataType_CommandResponse : pb::IMessage<DataType_CommandResponse> {
    private static readonly pb::MessageParser<DataType_CommandResponse> _parser = new pb::MessageParser<DataType_CommandResponse>(() => new DataType_CommandResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DataType_CommandResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.CWashExecutionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataType_CommandResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataType_CommandResponse(DataType_CommandResponse other) : this() {
      commandResponse_ = other.commandResponse_ != null ? other.commandResponse_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataType_CommandResponse Clone() {
      return new DataType_CommandResponse(this);
    }

    /// <summary>Field number for the "CommandResponse" field.</summary>
    public const int CommandResponseFieldNumber = 1;
    private global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Types.CommandResponse_Struct commandResponse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Types.CommandResponse_Struct CommandResponse {
      get { return commandResponse_; }
      set {
        commandResponse_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DataType_CommandResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DataType_CommandResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CommandResponse, other.CommandResponse)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (commandResponse_ != null) hash ^= CommandResponse.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (commandResponse_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommandResponse);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (commandResponse_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommandResponse);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DataType_CommandResponse other) {
      if (other == null) {
        return;
      }
      if (other.commandResponse_ != null) {
        if (commandResponse_ == null) {
          commandResponse_ = new global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Types.CommandResponse_Struct();
        }
        CommandResponse.MergeFrom(other.CommandResponse);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (commandResponse_ == null) {
              commandResponse_ = new global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Types.CommandResponse_Struct();
            }
            input.ReadMessage(commandResponse_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DataType_CommandResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class CommandResponse_Struct : pb::IMessage<CommandResponse_Struct> {
        private static readonly pb::MessageParser<CommandResponse_Struct> _parser = new pb::MessageParser<CommandResponse_Struct>(() => new CommandResponse_Struct());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CommandResponse_Struct> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CommandResponse_Struct() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CommandResponse_Struct(CommandResponse_Struct other) : this() {
          commandName_ = other.commandName_ != null ? other.commandName_.Clone() : null;
          firmwareResponse_ = other.firmwareResponse_ != null ? other.firmwareResponse_.Clone() : null;
          executionStartedAt_ = other.executionStartedAt_ != null ? other.executionStartedAt_.Clone() : null;
          executionFinishedAt_ = other.executionFinishedAt_ != null ? other.executionFinishedAt_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CommandResponse_Struct Clone() {
          return new CommandResponse_Struct(this);
        }

        /// <summary>Field number for the "CommandName" field.</summary>
        public const int CommandNameFieldNumber = 1;
        private global::Sila2.Org.Silastandard.String commandName_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Sila2.Org.Silastandard.String CommandName {
          get { return commandName_; }
          set {
            commandName_ = value;
          }
        }

        /// <summary>Field number for the "FirmwareResponse" field.</summary>
        public const int FirmwareResponseFieldNumber = 2;
        private global::Sila2.Org.Silastandard.String firmwareResponse_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Sila2.Org.Silastandard.String FirmwareResponse {
          get { return firmwareResponse_; }
          set {
            firmwareResponse_ = value;
          }
        }

        /// <summary>Field number for the "ExecutionStartedAt" field.</summary>
        public const int ExecutionStartedAtFieldNumber = 3;
        private global::Sila2.Org.Silastandard.Timestamp executionStartedAt_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Sila2.Org.Silastandard.Timestamp ExecutionStartedAt {
          get { return executionStartedAt_; }
          set {
            executionStartedAt_ = value;
          }
        }

        /// <summary>Field number for the "ExecutionFinishedAt" field.</summary>
        public const int ExecutionFinishedAtFieldNumber = 4;
        private global::Sila2.Org.Silastandard.Timestamp executionFinishedAt_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Sila2.Org.Silastandard.Timestamp ExecutionFinishedAt {
          get { return executionFinishedAt_; }
          set {
            executionFinishedAt_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as CommandResponse_Struct);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CommandResponse_Struct other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(CommandName, other.CommandName)) return false;
          if (!object.Equals(FirmwareResponse, other.FirmwareResponse)) return false;
          if (!object.Equals(ExecutionStartedAt, other.ExecutionStartedAt)) return false;
          if (!object.Equals(ExecutionFinishedAt, other.ExecutionFinishedAt)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (commandName_ != null) hash ^= CommandName.GetHashCode();
          if (firmwareResponse_ != null) hash ^= FirmwareResponse.GetHashCode();
          if (executionStartedAt_ != null) hash ^= ExecutionStartedAt.GetHashCode();
          if (executionFinishedAt_ != null) hash ^= ExecutionFinishedAt.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (commandName_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(CommandName);
          }
          if (firmwareResponse_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(FirmwareResponse);
          }
          if (executionStartedAt_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(ExecutionStartedAt);
          }
          if (executionFinishedAt_ != null) {
            output.WriteRawTag(34);
            output.WriteMessage(ExecutionFinishedAt);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (commandName_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommandName);
          }
          if (firmwareResponse_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirmwareResponse);
          }
          if (executionStartedAt_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExecutionStartedAt);
          }
          if (executionFinishedAt_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExecutionFinishedAt);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CommandResponse_Struct other) {
          if (other == null) {
            return;
          }
          if (other.commandName_ != null) {
            if (commandName_ == null) {
              commandName_ = new global::Sila2.Org.Silastandard.String();
            }
            CommandName.MergeFrom(other.CommandName);
          }
          if (other.firmwareResponse_ != null) {
            if (firmwareResponse_ == null) {
              firmwareResponse_ = new global::Sila2.Org.Silastandard.String();
            }
            FirmwareResponse.MergeFrom(other.FirmwareResponse);
          }
          if (other.executionStartedAt_ != null) {
            if (executionStartedAt_ == null) {
              executionStartedAt_ = new global::Sila2.Org.Silastandard.Timestamp();
            }
            ExecutionStartedAt.MergeFrom(other.ExecutionStartedAt);
          }
          if (other.executionFinishedAt_ != null) {
            if (executionFinishedAt_ == null) {
              executionFinishedAt_ = new global::Sila2.Org.Silastandard.Timestamp();
            }
            ExecutionFinishedAt.MergeFrom(other.ExecutionFinishedAt);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                if (commandName_ == null) {
                  commandName_ = new global::Sila2.Org.Silastandard.String();
                }
                input.ReadMessage(commandName_);
                break;
              }
              case 18: {
                if (firmwareResponse_ == null) {
                  firmwareResponse_ = new global::Sila2.Org.Silastandard.String();
                }
                input.ReadMessage(firmwareResponse_);
                break;
              }
              case 26: {
                if (executionStartedAt_ == null) {
                  executionStartedAt_ = new global::Sila2.Org.Silastandard.Timestamp();
                }
                input.ReadMessage(executionStartedAt_);
                break;
              }
              case 34: {
                if (executionFinishedAt_ == null) {
                  executionFinishedAt_ = new global::Sila2.Org.Silastandard.Timestamp();
                }
                input.ReadMessage(executionFinishedAt_);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  public sealed partial class ExecuteCommand_Parameters : pb::IMessage<ExecuteCommand_Parameters> {
    private static readonly pb::MessageParser<ExecuteCommand_Parameters> _parser = new pb::MessageParser<ExecuteCommand_Parameters>(() => new ExecuteCommand_Parameters());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExecuteCommand_Parameters> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.CWashExecutionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteCommand_Parameters() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteCommand_Parameters(ExecuteCommand_Parameters other) : this() {
      command_ = other.command_ != null ? other.command_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteCommand_Parameters Clone() {
      return new ExecuteCommand_Parameters(this);
    }

    /// <summary>Field number for the "Command" field.</summary>
    public const int CommandFieldNumber = 1;
    private global::Sila2.Org.Silastandard.Binary command_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Sila2.Org.Silastandard.Binary Command {
      get { return command_; }
      set {
        command_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExecuteCommand_Parameters);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExecuteCommand_Parameters other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Command, other.Command)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (command_ != null) hash ^= Command.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (command_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Command);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (command_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Command);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExecuteCommand_Parameters other) {
      if (other == null) {
        return;
      }
      if (other.command_ != null) {
        if (command_ == null) {
          command_ = new global::Sila2.Org.Silastandard.Binary();
        }
        Command.MergeFrom(other.Command);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (command_ == null) {
              command_ = new global::Sila2.Org.Silastandard.Binary();
            }
            input.ReadMessage(command_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExecuteCommand_Responses : pb::IMessage<ExecuteCommand_Responses> {
    private static readonly pb::MessageParser<ExecuteCommand_Responses> _parser = new pb::MessageParser<ExecuteCommand_Responses>(() => new ExecuteCommand_Responses());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExecuteCommand_Responses> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.CWashExecutionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteCommand_Responses() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteCommand_Responses(ExecuteCommand_Responses other) : this() {
      commandResponse_ = other.commandResponse_ != null ? other.commandResponse_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteCommand_Responses Clone() {
      return new ExecuteCommand_Responses(this);
    }

    /// <summary>Field number for the "CommandResponse" field.</summary>
    public const int CommandResponseFieldNumber = 1;
    private global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse commandResponse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse CommandResponse {
      get { return commandResponse_; }
      set {
        commandResponse_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExecuteCommand_Responses);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExecuteCommand_Responses other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CommandResponse, other.CommandResponse)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (commandResponse_ != null) hash ^= CommandResponse.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (commandResponse_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommandResponse);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (commandResponse_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommandResponse);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExecuteCommand_Responses other) {
      if (other == null) {
        return;
      }
      if (other.commandResponse_ != null) {
        if (commandResponse_ == null) {
          commandResponse_ = new global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse();
        }
        CommandResponse.MergeFrom(other.CommandResponse);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (commandResponse_ == null) {
              commandResponse_ = new global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.DataType_CommandResponse();
            }
            input.ReadMessage(commandResponse_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExecuteProtocol_Parameters : pb::IMessage<ExecuteProtocol_Parameters> {
    private static readonly pb::MessageParser<ExecuteProtocol_Parameters> _parser = new pb::MessageParser<ExecuteProtocol_Parameters>(() => new ExecuteProtocol_Parameters());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExecuteProtocol_Parameters> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.CWashExecutionServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteProtocol_Parameters() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteProtocol_Parameters(ExecuteProtocol_Parameters other) : this() {
      protocol_ = other.protocol_ != null ? other.protocol_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteProtocol_Parameters Clone() {
      return new ExecuteProtocol_Parameters(this);
    }

    /// <summary>Field number for the "Protocol" field.</summary>
    public const int ProtocolFieldNumber = 1;
    private global::Sila2.Org.Silastandard.Binary protocol_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Sila2.Org.Silastandard.Binary Protocol {
      get { return protocol_; }
      set {
        protocol_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExecuteProtocol_Parameters);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExecuteProtocol_Parameters other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Protocol, other.Protocol)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (protocol_ != null) hash ^= Protocol.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (protocol_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Protocol);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (protocol_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Protocol);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExecuteProtocol_Parameters other) {
      if (other == null) {
        return;
      }
      if (other.protocol_ != null) {
        if (protocol_ == null) {
          protocol_ = new global::Sila2.Org.Silastandard.Binary();
        }
        Protocol.MergeFrom(other.Protocol);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (protocol_ == null) {
              protocol_ = new global::Sila2.Org.Silastandard.Binary();
            }
            input.ReadMessage(protocol_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExecuteProtocol_Responses : pb::IMessage<ExecuteProtocol_Responses> {
    private static readonly pb::MessageParser<ExecuteProtocol_Responses> _parser = new pb::MessageParser<ExecuteProtocol_Responses>(() => new ExecuteProtocol_Responses());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExecuteProtocol_Responses> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1.CWashExecutionServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteProtocol_Responses() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteProtocol_Responses(ExecuteProtocol_Responses other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExecuteProtocol_Responses Clone() {
      return new ExecuteProtocol_Responses(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExecuteProtocol_Responses);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExecuteProtocol_Responses other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExecuteProtocol_Responses other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code