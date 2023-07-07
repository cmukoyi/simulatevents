//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: AccidentLogProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccidentLog")]
  public partial class AccidentLog : global::ProtoBuf.IExtensible
  {
    public AccidentLog()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.AccidentLog,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _Rpm;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rpm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Rpm
    {
      get { return _Rpm?? default(uint); }
      set { _Rpm = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmSpecified
    {
      get { return this._Rpm != null; }
      set { if (value == (this._Rpm== null)) this._Rpm = value ? this.Rpm : (uint?)null; }
    }
    private bool ShouldSerializerpm() { return RpmSpecified; }
    private void Resetrpm() { RpmSpecified = false; }
    
    private uint? _TripDistance;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"trip_distance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TripDistance
    {
      get { return _TripDistance?? default(uint); }
      set { _TripDistance = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TripDistanceSpecified
    {
      get { return this._TripDistance != null; }
      set { if (value == (this._TripDistance== null)) this._TripDistance = value ? this.TripDistance : (uint?)null; }
    }
    private bool ShouldSerializetrip_distance() { return TripDistanceSpecified; }
    private void Resettrip_distance() { TripDistanceSpecified = false; }
    
    private float? _AccelerometerX;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"accelerometer_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AccelerometerX
    {
      get { return _AccelerometerX?? default(float); }
      set { _AccelerometerX = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AccelerometerXSpecified
    {
      get { return this._AccelerometerX != null; }
      set { if (value == (this._AccelerometerX== null)) this._AccelerometerX = value ? this.AccelerometerX : (float?)null; }
    }
    private bool ShouldSerializeaccelerometer_x() { return AccelerometerXSpecified; }
    private void Resetaccelerometer_x() { AccelerometerXSpecified = false; }
    
    private float? _AccelerometerY;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"accelerometer_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AccelerometerY
    {
      get { return _AccelerometerY?? default(float); }
      set { _AccelerometerY = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AccelerometerYSpecified
    {
      get { return this._AccelerometerY != null; }
      set { if (value == (this._AccelerometerY== null)) this._AccelerometerY = value ? this.AccelerometerY : (float?)null; }
    }
    private bool ShouldSerializeaccelerometer_y() { return AccelerometerYSpecified; }
    private void Resetaccelerometer_y() { AccelerometerYSpecified = false; }
    
    private float? _AccelerometerZ;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"accelerometer_z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AccelerometerZ
    {
      get { return _AccelerometerZ?? default(float); }
      set { _AccelerometerZ = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AccelerometerZSpecified
    {
      get { return this._AccelerometerZ != null; }
      set { if (value == (this._AccelerometerZ== null)) this._AccelerometerZ = value ? this.AccelerometerZ : (float?)null; }
    }
    private bool ShouldSerializeaccelerometer_z() { return AccelerometerZSpecified; }
    private void Resetaccelerometer_z() { AccelerometerZSpecified = false; }
    
    private uint? _AccidentReconIndex;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"accident_recon_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint AccidentReconIndex
    {
      get { return _AccidentReconIndex?? default(uint); }
      set { _AccidentReconIndex = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AccidentReconIndexSpecified
    {
      get { return this._AccidentReconIndex != null; }
      set { if (value == (this._AccidentReconIndex== null)) this._AccidentReconIndex = value ? this.AccidentReconIndex : (uint?)null; }
    }
    private bool ShouldSerializeaccident_recon_index() { return AccidentReconIndexSpecified; }
    private void Resetaccident_recon_index() { AccidentReconIndexSpecified = false; }
    
    private uint? _Altitude;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"altitude", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Altitude
    {
      get { return _Altitude?? default(uint); }
      set { _Altitude = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AltitudeSpecified
    {
      get { return this._Altitude != null; }
      set { if (value == (this._Altitude== null)) this._Altitude = value ? this.Altitude : (uint?)null; }
    }
    private bool ShouldSerializealtitude() { return AltitudeSpecified; }
    private void Resetaltitude() { AltitudeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}