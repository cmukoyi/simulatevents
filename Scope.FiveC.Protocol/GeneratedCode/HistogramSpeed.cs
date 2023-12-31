//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: HistogramSpeedProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HistogramSpeed")]
  public partial class HistogramSpeed : global::ProtoBuf.IExtensible
  {
    public HistogramSpeed()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.HistogramSpeed,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _TripDuration;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"trip_duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private uint? _SpeedBand0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"speed_band0", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand0
    {
      get { return _SpeedBand0?? default(uint); }
      set { _SpeedBand0 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand0Specified
    {
      get { return this._SpeedBand0 != null; }
      set { if (value == (this._SpeedBand0== null)) this._SpeedBand0 = value ? this.SpeedBand0 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band0() { return SpeedBand0Specified; }
    private void Resetspeed_band0() { SpeedBand0Specified = false; }
    
    private uint? _SpeedBand1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"speed_band1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand1
    {
      get { return _SpeedBand1?? default(uint); }
      set { _SpeedBand1 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand1Specified
    {
      get { return this._SpeedBand1 != null; }
      set { if (value == (this._SpeedBand1== null)) this._SpeedBand1 = value ? this.SpeedBand1 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band1() { return SpeedBand1Specified; }
    private void Resetspeed_band1() { SpeedBand1Specified = false; }
    
    private uint? _SpeedBand2;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"speed_band2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand2
    {
      get { return _SpeedBand2?? default(uint); }
      set { _SpeedBand2 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand2Specified
    {
      get { return this._SpeedBand2 != null; }
      set { if (value == (this._SpeedBand2== null)) this._SpeedBand2 = value ? this.SpeedBand2 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band2() { return SpeedBand2Specified; }
    private void Resetspeed_band2() { SpeedBand2Specified = false; }
    
    private uint? _SpeedBand3;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"speed_band3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand3
    {
      get { return _SpeedBand3?? default(uint); }
      set { _SpeedBand3 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand3Specified
    {
      get { return this._SpeedBand3 != null; }
      set { if (value == (this._SpeedBand3== null)) this._SpeedBand3 = value ? this.SpeedBand3 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band3() { return SpeedBand3Specified; }
    private void Resetspeed_band3() { SpeedBand3Specified = false; }
    
    private uint? _SpeedBand4;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"speed_band4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand4
    {
      get { return _SpeedBand4?? default(uint); }
      set { _SpeedBand4 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand4Specified
    {
      get { return this._SpeedBand4 != null; }
      set { if (value == (this._SpeedBand4== null)) this._SpeedBand4 = value ? this.SpeedBand4 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band4() { return SpeedBand4Specified; }
    private void Resetspeed_band4() { SpeedBand4Specified = false; }
    
    private uint? _SpeedBand5;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"speed_band5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand5
    {
      get { return _SpeedBand5?? default(uint); }
      set { _SpeedBand5 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand5Specified
    {
      get { return this._SpeedBand5 != null; }
      set { if (value == (this._SpeedBand5== null)) this._SpeedBand5 = value ? this.SpeedBand5 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band5() { return SpeedBand5Specified; }
    private void Resetspeed_band5() { SpeedBand5Specified = false; }
    
    private uint? _SpeedBand6;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"speed_band6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand6
    {
      get { return _SpeedBand6?? default(uint); }
      set { _SpeedBand6 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand6Specified
    {
      get { return this._SpeedBand6 != null; }
      set { if (value == (this._SpeedBand6== null)) this._SpeedBand6 = value ? this.SpeedBand6 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band6() { return SpeedBand6Specified; }
    private void Resetspeed_band6() { SpeedBand6Specified = false; }
    
    private uint? _SpeedBand7;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"speed_band7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand7
    {
      get { return _SpeedBand7?? default(uint); }
      set { _SpeedBand7 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand7Specified
    {
      get { return this._SpeedBand7 != null; }
      set { if (value == (this._SpeedBand7== null)) this._SpeedBand7 = value ? this.SpeedBand7 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band7() { return SpeedBand7Specified; }
    private void Resetspeed_band7() { SpeedBand7Specified = false; }
    
    private uint? _SpeedBand8;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"speed_band8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand8
    {
      get { return _SpeedBand8?? default(uint); }
      set { _SpeedBand8 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand8Specified
    {
      get { return this._SpeedBand8 != null; }
      set { if (value == (this._SpeedBand8== null)) this._SpeedBand8 = value ? this.SpeedBand8 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band8() { return SpeedBand8Specified; }
    private void Resetspeed_band8() { SpeedBand8Specified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}