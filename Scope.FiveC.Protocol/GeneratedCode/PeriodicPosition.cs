//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: PeriodicPositionProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PeriodicPosition")]
  public partial class PeriodicPosition : global::ProtoBuf.IExtensible
  {
    public PeriodicPosition()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.PeriodicPosition,
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
    
    private uint? _TripDurationSeconds;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"trip_duration_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TripDurationSeconds
    {
      get { return _TripDurationSeconds?? default(uint); }
      set { _TripDurationSeconds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TripDurationSecondsSpecified
    {
      get { return this._TripDurationSeconds != null; }
      set { if (value == (this._TripDurationSeconds== null)) this._TripDurationSeconds = value ? this.TripDurationSeconds : (uint?)null; }
    }
    private bool ShouldSerializetrip_duration_seconds() { return TripDurationSecondsSpecified; }
    private void Resettrip_duration_seconds() { TripDurationSecondsSpecified = false; }
    
    private uint? _TripDistanceMeters;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"trip_distance_meters", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TripDistanceMeters
    {
      get { return _TripDistanceMeters?? default(uint); }
      set { _TripDistanceMeters = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TripDistanceMetersSpecified
    {
      get { return this._TripDistanceMeters != null; }
      set { if (value == (this._TripDistanceMeters== null)) this._TripDistanceMeters = value ? this.TripDistanceMeters : (uint?)null; }
    }
    private bool ShouldSerializetrip_distance_meters() { return TripDistanceMetersSpecified; }
    private void Resettrip_distance_meters() { TripDistanceMetersSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}