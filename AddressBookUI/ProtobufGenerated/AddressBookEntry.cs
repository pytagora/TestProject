// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: AddressBookEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Abook {

  /// <summary>Holder for reflection information generated from AddressBookEntry.proto</summary>
  public static partial class AddressBookEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for AddressBookEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressBookEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZBZGRyZXNzQm9va0VudHJ5LnByb3RvEgVBYm9vayJ2ChBBZGRyZXNzQm9v",
            "a0VudHJ5EgoKAmlkGAEgASgFEhEKCWZpcnN0TmFtZRgCIAEoCRIQCghsYXN0",
            "TmFtZRgDIAEoCRIPCgdhZGRyZXNzGAQgASgJEhIKCnBvc3RhbENvZGUYBSAB",
            "KAUSDAoEY2l0eRgGIAEoCUIL+AEBqgIFQWJvb2tiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Abook.AddressBookEntry), global::Abook.AddressBookEntry.Parser, new[]{ "Id", "FirstName", "LastName", "Address", "PostalCode", "City" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddressBookEntry : pb::IMessage<AddressBookEntry> {
    private static readonly pb::MessageParser<AddressBookEntry> _parser = new pb::MessageParser<AddressBookEntry>(() => new AddressBookEntry());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBookEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Abook.AddressBookEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookEntry(AddressBookEntry other) : this() {
      id_ = other.id_;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      address_ = other.address_;
      postalCode_ = other.postalCode_;
      city_ = other.city_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookEntry Clone() {
      return new AddressBookEntry(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "firstName" field.</summary>
    public const int FirstNameFieldNumber = 2;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastName" field.</summary>
    public const int LastNameFieldNumber = 3;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 4;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "postalCode" field.</summary>
    public const int PostalCodeFieldNumber = 5;
    private int postalCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = value;
      }
    }

    /// <summary>Field number for the "city" field.</summary>
    public const int CityFieldNumber = 6;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBookEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBookEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (Address != other.Address) return false;
      if (PostalCode != other.PostalCode) return false;
      if (City != other.City) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (PostalCode != 0) hash ^= PostalCode.GetHashCode();
      if (City.Length != 0) hash ^= City.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Address);
      }
      if (PostalCode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(PostalCode);
      }
      if (City.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(City);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (PostalCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostalCode);
      }
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBookEntry other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.PostalCode != 0) {
        PostalCode = other.PostalCode;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            FirstName = input.ReadString();
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            Address = input.ReadString();
            break;
          }
          case 40: {
            PostalCode = input.ReadInt32();
            break;
          }
          case 50: {
            City = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
