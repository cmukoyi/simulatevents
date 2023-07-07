//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: DriverIdentificationProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DriverIdentification")]
  public partial class DriverIdentification : global::ProtoBuf.IExtensible
  {
    public DriverIdentification()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.DriverIdentification,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _DataType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint DataType
    {
      get { return _DataType?? (uint)0; }
      set { _DataType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DataTypeSpecified
    {
      get { return this._DataType != null; }
      set { if (value == (this._DataType== null)) this._DataType = value ? this.DataType : (uint?)null; }
    }
    private bool ShouldSerializedata_type() { return DataTypeSpecified; }
    private void Resetdata_type() { DataTypeSpecified = false; }
    
    private byte[] _DriverId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"driver_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] DriverId
    {
      get { return _DriverId?? null; }
      set { _DriverId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DriverIdSpecified
    {
      get { return this._DriverId != null; }
      set { if (value == (this._DriverId== null)) this._DriverId = value ? this.DriverId : (byte[])null; }
    }
    private bool ShouldSerializedriver_id() { return DriverIdSpecified; }
    private void Resetdriver_id() { DriverIdSpecified = false; }
    
    private uint? _LicenseType;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"license_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint LicenseType
    {
      get { return _LicenseType?? default(uint); }
      set { _LicenseType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool LicenseTypeSpecified
    {
      get { return this._LicenseType != null; }
      set { if (value == (this._LicenseType== null)) this._LicenseType = value ? this.LicenseType : (uint?)null; }
    }
    private bool ShouldSerializelicense_type() { return LicenseTypeSpecified; }
    private void Resetlicense_type() { LicenseTypeSpecified = false; }
    
    private byte[] _LicenseId;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"license_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] LicenseId
    {
      get { return _LicenseId?? null; }
      set { _LicenseId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool LicenseIdSpecified
    {
      get { return this._LicenseId != null; }
      set { if (value == (this._LicenseId== null)) this._LicenseId = value ? this.LicenseId : (byte[])null; }
    }
    private bool ShouldSerializelicense_id() { return LicenseIdSpecified; }
    private void Resetlicense_id() { LicenseIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}