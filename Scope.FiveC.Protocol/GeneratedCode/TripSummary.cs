//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: TripSummaryProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TripSummary")]
  public partial class TripSummary : global::ProtoBuf.IExtensible
  {
    public TripSummary()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.TripSummary,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private double? _LatitudeStart;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"latitude_start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double LatitudeStart
    {
      get { return _LatitudeStart?? default(double); }
      set { _LatitudeStart = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool LatitudeStartSpecified
    {
      get { return this._LatitudeStart != null; }
      set { if (value == (this._LatitudeStart== null)) this._LatitudeStart = value ? this.LatitudeStart : (double?)null; }
    }
    private bool ShouldSerializelatitude_start() { return LatitudeStartSpecified; }
    private void Resetlatitude_start() { LatitudeStartSpecified = false; }
    
    private double? _LongitudeStart;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"longitude_start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double LongitudeStart
    {
      get { return _LongitudeStart?? default(double); }
      set { _LongitudeStart = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool LongitudeStartSpecified
    {
      get { return this._LongitudeStart != null; }
      set { if (value == (this._LongitudeStart== null)) this._LongitudeStart = value ? this.LongitudeStart : (double?)null; }
    }
    private bool ShouldSerializelongitude_start() { return LongitudeStartSpecified; }
    private void Resetlongitude_start() { LongitudeStartSpecified = false; }
    
    private uint? _TripDuration;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"trip_duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TripDuration
    {
      get { return _TripDuration?? default(uint); }
      set { _TripDuration = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TripDurationSpecified
    {
      get { return this._TripDuration != null; }
      set { if (value == (this._TripDuration== null)) this._TripDuration = value ? this.TripDuration : (uint?)null; }
    }
    private bool ShouldSerializetrip_duration() { return TripDurationSpecified; }
    private void Resettrip_duration() { TripDurationSpecified = false; }
    
    private uint? _TripDistance;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"trip_distance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private uint? _TripMaxSpeed;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"trip_max_speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TripMaxSpeed
    {
      get { return _TripMaxSpeed?? default(uint); }
      set { _TripMaxSpeed = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TripMaxSpeedSpecified
    {
      get { return this._TripMaxSpeed != null; }
      set { if (value == (this._TripMaxSpeed== null)) this._TripMaxSpeed = value ? this.TripMaxSpeed : (uint?)null; }
    }
    private bool ShouldSerializetrip_max_speed() { return TripMaxSpeedSpecified; }
    private void Resettrip_max_speed() { TripMaxSpeedSpecified = false; }
    
    private uint? _GprsStatusStart;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"gprs_status_start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint GprsStatusStart
    {
      get { return _GprsStatusStart?? default(uint); }
      set { _GprsStatusStart = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool GprsStatusStartSpecified
    {
      get { return this._GprsStatusStart != null; }
      set { if (value == (this._GprsStatusStart== null)) this._GprsStatusStart = value ? this.GprsStatusStart : (uint?)null; }
    }
    private bool ShouldSerializegprs_status_start() { return GprsStatusStartSpecified; }
    private void Resetgprs_status_start() { GprsStatusStartSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}