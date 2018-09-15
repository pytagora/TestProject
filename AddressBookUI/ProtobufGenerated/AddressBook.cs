// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: AddressBook.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Abook {

  /// <summary>Holder for reflection information generated from AddressBook.proto</summary>
  public static partial class AddressBookReflection {

    #region Descriptor
    /// <summary>File descriptor for AddressBook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressBookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBZGRyZXNzQm9vay5wcm90bxIFQWJvb2saFkFkZHJlc3NCb29rRW50cnku",
            "cHJvdG8iNQoLQWRkcmVzc0Jvb2sSJgoFZW50cnkYASADKAsyFy5BYm9vay5B",
            "ZGRyZXNzQm9va0VudHJ5Qgv4AQGqAgVBYm9va2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Abook.AddressBookEntryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Abook.AddressBook), global::Abook.AddressBook.Parser, new[]{ "Entry" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddressBook : pb::IMessage<AddressBook> {
    private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Abook.AddressBookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook(AddressBook other) : this() {
      entry_ = other.entry_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook Clone() {
      return new AddressBook(this);
    }

    /// <summary>Field number for the "entry" field.</summary>
    public const int EntryFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Abook.AddressBookEntry> _repeated_entry_codec
        = pb::FieldCodec.ForMessage(10, global::Abook.AddressBookEntry.Parser);
    private readonly pbc::RepeatedField<global::Abook.AddressBookEntry> entry_ = new pbc::RepeatedField<global::Abook.AddressBookEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Abook.AddressBookEntry> Entry {
      get { return entry_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entry_.Equals(other.entry_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entry_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      entry_.WriteTo(output, _repeated_entry_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entry_.CalculateSize(_repeated_entry_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBook other) {
      if (other == null) {
        return;
      }
      entry_.Add(other.entry_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            entry_.AddEntriesFrom(input, _repeated_entry_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
