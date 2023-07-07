//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: PeriodicTemperatureProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PeriodicTemperature")]
  public partial class PeriodicTemperature : global::ProtoBuf.IExtensible
  {
    public PeriodicTemperature()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.PeriodicTemperature,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private int? _Sensor1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sensor1", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Sensor1
    {
      get { return _Sensor1?? default(int); }
      set { _Sensor1 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor1Specified
    {
      get { return this._Sensor1 != null; }
      set { if (value == (this._Sensor1== null)) this._Sensor1 = value ? this.Sensor1 : (int?)null; }
    }
    private bool ShouldSerializesensor1() { return Sensor1Specified; }
    private void Resetsensor1() { Sensor1Specified = false; }
    
    private int? _Sensor2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sensor2", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Sensor2
    {
      get { return _Sensor2?? default(int); }
      set { _Sensor2 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor2Specified
    {
      get { return this._Sensor2 != null; }
      set { if (value == (this._Sensor2== null)) this._Sensor2 = value ? this.Sensor2 : (int?)null; }
    }
    private bool ShouldSerializesensor2() { return Sensor2Specified; }
    private void Resetsensor2() { Sensor2Specified = false; }
    
    private int? _Sensor3;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"sensor3", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Sensor3
    {
      get { return _Sensor3?? default(int); }
      set { _Sensor3 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor3Specified
    {
      get { return this._Sensor3 != null; }
      set { if (value == (this._Sensor3== null)) this._Sensor3 = value ? this.Sensor3 : (int?)null; }
    }
    private bool ShouldSerializesensor3() { return Sensor3Specified; }
    private void Resetsensor3() { Sensor3Specified = false; }
    
    private int? _Sensor4;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"sensor4", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Sensor4
    {
      get { return _Sensor4?? default(int); }
      set { _Sensor4 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor4Specified
    {
      get { return this._Sensor4 != null; }
      set { if (value == (this._Sensor4== null)) this._Sensor4 = value ? this.Sensor4 : (int?)null; }
    }
    private bool ShouldSerializesensor4() { return Sensor4Specified; }
    private void Resetsensor4() { Sensor4Specified = false; }
    
    private bool? _Sensor1Valid;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"sensor1_valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Sensor1Valid
    {
      get { return _Sensor1Valid?? default(bool); }
      set { _Sensor1Valid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor1ValidSpecified
    {
      get { return this._Sensor1Valid != null; }
      set { if (value == (this._Sensor1Valid== null)) this._Sensor1Valid = value ? this.Sensor1Valid : (bool?)null; }
    }
    private bool ShouldSerializesensor1_valid() { return Sensor1ValidSpecified; }
    private void Resetsensor1_valid() { Sensor1ValidSpecified = false; }
    
    private bool? _Sensor2Valid;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"sensor2_valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Sensor2Valid
    {
      get { return _Sensor2Valid?? default(bool); }
      set { _Sensor2Valid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor2ValidSpecified
    {
      get { return this._Sensor2Valid != null; }
      set { if (value == (this._Sensor2Valid== null)) this._Sensor2Valid = value ? this.Sensor2Valid : (bool?)null; }
    }
    private bool ShouldSerializesensor2_valid() { return Sensor2ValidSpecified; }
    private void Resetsensor2_valid() { Sensor2ValidSpecified = false; }
    
    private bool? _Sensor3Valid;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sensor3_valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Sensor3Valid
    {
      get { return _Sensor3Valid?? default(bool); }
      set { _Sensor3Valid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor3ValidSpecified
    {
      get { return this._Sensor3Valid != null; }
      set { if (value == (this._Sensor3Valid== null)) this._Sensor3Valid = value ? this.Sensor3Valid : (bool?)null; }
    }
    private bool ShouldSerializesensor3_valid() { return Sensor3ValidSpecified; }
    private void Resetsensor3_valid() { Sensor3ValidSpecified = false; }
    
    private bool? _Sensor4Valid;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"sensor4_valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Sensor4Valid
    {
      get { return _Sensor4Valid?? default(bool); }
      set { _Sensor4Valid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Sensor4ValidSpecified
    {
      get { return this._Sensor4Valid != null; }
      set { if (value == (this._Sensor4Valid== null)) this._Sensor4Valid = value ? this.Sensor4Valid : (bool?)null; }
    }
    private bool ShouldSerializesensor4_valid() { return Sensor4ValidSpecified; }
    private void Resetsensor4_valid() { Sensor4ValidSpecified = false; }
    
    private uint? _TemperatureStatus;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"temperature_status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TemperatureStatus
    {
      get { return _TemperatureStatus?? default(uint); }
      set { _TemperatureStatus = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TemperatureStatusSpecified
    {
      get { return this._TemperatureStatus != null; }
      set { if (value == (this._TemperatureStatus== null)) this._TemperatureStatus = value ? this.TemperatureStatus : (uint?)null; }
    }
    private bool ShouldSerializetemperature_status() { return TemperatureStatusSpecified; }
    private void Resettemperature_status() { TemperatureStatusSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}