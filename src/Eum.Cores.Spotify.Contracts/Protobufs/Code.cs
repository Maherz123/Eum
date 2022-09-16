// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: spotify/login5/v3/challenges/code.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CPlayerLib.Login5.V3.Challenges
{

    /// <summary>Holder for reflection information generated from spotify/login5/v3/challenges/code.proto</summary>
    public static partial class CodeReflection
    {

        #region Descriptor
        /// <summary>File descriptor for spotify/login5/v3/challenges/code.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static CodeReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CidzcG90aWZ5L2xvZ2luNS92My9jaGFsbGVuZ2VzL2NvZGUucHJvdG8SHHNw",
                  "b3RpZnkubG9naW41LnYzLmNoYWxsZW5nZXMivAEKDUNvZGVDaGFsbGVuZ2US",
                  "QgoGbWV0aG9kGAEgASgOMjIuc3BvdGlmeS5sb2dpbjUudjMuY2hhbGxlbmdl",
                  "cy5Db2RlQ2hhbGxlbmdlLk1ldGhvZBITCgtjb2RlX2xlbmd0aBgCIAEoBRIS",
                  "CgpleHBpcmVzX2luGAMgASgFEh4KFmNhbm9uaWNhbF9waG9uZV9udW1iZXIY",
                  "BCABKAkiHgoGTWV0aG9kEgsKB1VOS05PV04QABIHCgNTTVMQASIcCgxDb2Rl",
                  "U29sdXRpb24SDAoEY29kZRgBIAEoCUIWChRjb20uc3BvdGlmeS5sb2dpbjV2",
                  "M2IGcHJvdG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CPlayerLib.Login5.V3.Challenges.CodeChallenge), global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Parser, new[]{ "Method", "CodeLength", "ExpiresIn", "CanonicalPhoneNumber" }, null, new[]{ typeof(global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CPlayerLib.Login5.V3.Challenges.CodeSolution), global::CPlayerLib.Login5.V3.Challenges.CodeSolution.Parser, new[]{ "Code" }, null, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class CodeChallenge : pb::IMessage<CodeChallenge>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<CodeChallenge> _parser = new pb::MessageParser<CodeChallenge>(() => new CodeChallenge());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CodeChallenge> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::CPlayerLib.Login5.V3.Challenges.CodeReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CodeChallenge()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CodeChallenge(CodeChallenge other) : this()
        {
            method_ = other.method_;
            codeLength_ = other.codeLength_;
            expiresIn_ = other.expiresIn_;
            canonicalPhoneNumber_ = other.canonicalPhoneNumber_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CodeChallenge Clone()
        {
            return new CodeChallenge(this);
        }

        /// <summary>Field number for the "method" field.</summary>
        public const int MethodFieldNumber = 1;
        private global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method method_ = global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method.Unknown;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method Method
        {
            get { return method_; }
            set
            {
                method_ = value;
            }
        }

        /// <summary>Field number for the "code_length" field.</summary>
        public const int CodeLengthFieldNumber = 2;
        private int codeLength_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CodeLength
        {
            get { return codeLength_; }
            set
            {
                codeLength_ = value;
            }
        }

        /// <summary>Field number for the "expires_in" field.</summary>
        public const int ExpiresInFieldNumber = 3;
        private int expiresIn_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int ExpiresIn
        {
            get { return expiresIn_; }
            set
            {
                expiresIn_ = value;
            }
        }

        /// <summary>Field number for the "canonical_phone_number" field.</summary>
        public const int CanonicalPhoneNumberFieldNumber = 4;
        private string canonicalPhoneNumber_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CanonicalPhoneNumber
        {
            get { return canonicalPhoneNumber_; }
            set
            {
                canonicalPhoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as CodeChallenge);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CodeChallenge other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Method != other.Method) return false;
            if (CodeLength != other.CodeLength) return false;
            if (ExpiresIn != other.ExpiresIn) return false;
            if (CanonicalPhoneNumber != other.CanonicalPhoneNumber) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Method != global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method.Unknown) hash ^= Method.GetHashCode();
            if (CodeLength != 0) hash ^= CodeLength.GetHashCode();
            if (ExpiresIn != 0) hash ^= ExpiresIn.GetHashCode();
            if (CanonicalPhoneNumber.Length != 0) hash ^= CanonicalPhoneNumber.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Method != global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Method);
      }
      if (CodeLength != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CodeLength);
      }
      if (ExpiresIn != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ExpiresIn);
      }
      if (CanonicalPhoneNumber.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CanonicalPhoneNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (Method != global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method.Unknown)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Method);
            }
            if (CodeLength != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(CodeLength);
            }
            if (ExpiresIn != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(ExpiresIn);
            }
            if (CanonicalPhoneNumber.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(CanonicalPhoneNumber);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Method != global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method.Unknown)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Method);
            }
            if (CodeLength != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(CodeLength);
            }
            if (ExpiresIn != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ExpiresIn);
            }
            if (CanonicalPhoneNumber.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(CanonicalPhoneNumber);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CodeChallenge other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Method != global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method.Unknown)
            {
                Method = other.Method;
            }
            if (other.CodeLength != 0)
            {
                CodeLength = other.CodeLength;
            }
            if (other.ExpiresIn != 0)
            {
                ExpiresIn = other.ExpiresIn;
            }
            if (other.CanonicalPhoneNumber.Length != 0)
            {
                CanonicalPhoneNumber = other.CanonicalPhoneNumber;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Method = (global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method) input.ReadEnum();
            break;
          }
          case 16: {
            CodeLength = input.ReadInt32();
            break;
          }
          case 24: {
            ExpiresIn = input.ReadInt32();
            break;
          }
          case 34: {
            CanonicalPhoneNumber = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 8:
                        {
                            Method = (global::CPlayerLib.Login5.V3.Challenges.CodeChallenge.Types.Method)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            CodeLength = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            ExpiresIn = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            CanonicalPhoneNumber = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the CodeChallenge message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types
        {
            public enum Method
            {
                [pbr::OriginalName("UNKNOWN")] Unknown = 0,
                [pbr::OriginalName("SMS")] Sms = 1,
            }

        }
        #endregion

    }

    public sealed partial class CodeSolution : pb::IMessage<CodeSolution>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<CodeSolution> _parser = new pb::MessageParser<CodeSolution>(() => new CodeSolution());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CodeSolution> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::CPlayerLib.Login5.V3.Challenges.CodeReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CodeSolution()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CodeSolution(CodeSolution other) : this()
        {
            code_ = other.code_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CodeSolution Clone()
        {
            return new CodeSolution(this);
        }

        /// <summary>Field number for the "code" field.</summary>
        public const int CodeFieldNumber = 1;
        private string code_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Code
        {
            get { return code_; }
            set
            {
                code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as CodeSolution);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CodeSolution other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Code != other.Code) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Code.Length != 0) hash ^= Code.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Code.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Code);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (Code.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Code);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Code.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CodeSolution other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Code.Length != 0)
            {
                Code = other.Code;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Code = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Code = input.ReadString();
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
