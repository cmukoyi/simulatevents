//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: AccidentAnalysis10sEventProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccidentAnalysis10sEvent")]
  public partial class AccidentAnalysis10sEvent : global::ProtoBuf.IExtensible
  {
    public AccidentAnalysis10sEvent()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.AccidentAnalysis10sEvent,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _EventDurationMillisceonds;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"event_duration_millisceonds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EventDurationMillisceonds
    {
      get { return _EventDurationMillisceonds?? default(uint); }
      set { _EventDurationMillisceonds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool EventDurationMillisceondsSpecified
    {
      get { return this._EventDurationMillisceonds != null; }
      set { if (value == (this._EventDurationMillisceonds== null)) this._EventDurationMillisceonds = value ? this.EventDurationMillisceonds : (uint?)null; }
    }
    private bool ShouldSerializeevent_duration_millisceonds() { return EventDurationMillisceondsSpecified; }
    private void Resetevent_duration_millisceonds() { EventDurationMillisceondsSpecified = false; }
    
    private uint? _StartSpeedKmh;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"start_speed_kmh", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint StartSpeedKmh
    {
      get { return _StartSpeedKmh?? default(uint); }
      set { _StartSpeedKmh = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool StartSpeedKmhSpecified
    {
      get { return this._StartSpeedKmh != null; }
      set { if (value == (this._StartSpeedKmh== null)) this._StartSpeedKmh = value ? this.StartSpeedKmh : (uint?)null; }
    }
    private bool ShouldSerializestart_speed_kmh() { return StartSpeedKmhSpecified; }
    private void Resetstart_speed_kmh() { StartSpeedKmhSpecified = false; }
    
    private double? _AccidentLatitude;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"accident_latitude", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double AccidentLatitude
    {
      get { return _AccidentLatitude?? default(double); }
      set { _AccidentLatitude = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AccidentLatitudeSpecified
    {
      get { return this._AccidentLatitude != null; }
      set { if (value == (this._AccidentLatitude== null)) this._AccidentLatitude = value ? this.AccidentLatitude : (double?)null; }
    }
    private bool ShouldSerializeaccident_latitude() { return AccidentLatitudeSpecified; }
    private void Resetaccident_latitude() { AccidentLatitudeSpecified = false; }
    
    private double? _AccidentLongitude;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"accident_longitude", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double AccidentLongitude
    {
      get { return _AccidentLongitude?? default(double); }
      set { _AccidentLongitude = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AccidentLongitudeSpecified
    {
      get { return this._AccidentLongitude != null; }
      set { if (value == (this._AccidentLongitude== null)) this._AccidentLongitude = value ? this.AccidentLongitude : (double?)null; }
    }
    private bool ShouldSerializeaccident_longitude() { return AccidentLongitudeSpecified; }
    private void Resetaccident_longitude() { AccidentLongitudeSpecified = false; }
    
    private float? _MaxAccelerationR;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"max_acceleration_r", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float MaxAccelerationR
    {
      get { return _MaxAccelerationR?? default(float); }
      set { _MaxAccelerationR = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool MaxAccelerationRSpecified
    {
      get { return this._MaxAccelerationR != null; }
      set { if (value == (this._MaxAccelerationR== null)) this._MaxAccelerationR = value ? this.MaxAccelerationR : (float?)null; }
    }
    private bool ShouldSerializemax_acceleration_r() { return MaxAccelerationRSpecified; }
    private void Resetmax_acceleration_r() { MaxAccelerationRSpecified = false; }
    
    private float? _AverageAccelerationR;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"average_acceleration_r", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AverageAccelerationR
    {
      get { return _AverageAccelerationR?? default(float); }
      set { _AverageAccelerationR = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AverageAccelerationRSpecified
    {
      get { return this._AverageAccelerationR != null; }
      set { if (value == (this._AverageAccelerationR== null)) this._AverageAccelerationR = value ? this.AverageAccelerationR : (float?)null; }
    }
    private bool ShouldSerializeaverage_acceleration_r() { return AverageAccelerationRSpecified; }
    private void Resetaverage_acceleration_r() { AverageAccelerationRSpecified = false; }
    
    private float? _AverageAccelerationX;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"average_acceleration_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AverageAccelerationX
    {
      get { return _AverageAccelerationX?? default(float); }
      set { _AverageAccelerationX = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AverageAccelerationXSpecified
    {
      get { return this._AverageAccelerationX != null; }
      set { if (value == (this._AverageAccelerationX== null)) this._AverageAccelerationX = value ? this.AverageAccelerationX : (float?)null; }
    }
    private bool ShouldSerializeaverage_acceleration_x() { return AverageAccelerationXSpecified; }
    private void Resetaverage_acceleration_x() { AverageAccelerationXSpecified = false; }
    
    private float? _AverageAccelerationY;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"average_acceleration_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AverageAccelerationY
    {
      get { return _AverageAccelerationY?? default(float); }
      set { _AverageAccelerationY = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AverageAccelerationYSpecified
    {
      get { return this._AverageAccelerationY != null; }
      set { if (value == (this._AverageAccelerationY== null)) this._AverageAccelerationY = value ? this.AverageAccelerationY : (float?)null; }
    }
    private bool ShouldSerializeaverage_acceleration_y() { return AverageAccelerationYSpecified; }
    private void Resetaverage_acceleration_y() { AverageAccelerationYSpecified = false; }
    
    private float? _AverageAccelerationZ;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"average_acceleration_z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float AverageAccelerationZ
    {
      get { return _AverageAccelerationZ?? default(float); }
      set { _AverageAccelerationZ = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AverageAccelerationZSpecified
    {
      get { return this._AverageAccelerationZ != null; }
      set { if (value == (this._AverageAccelerationZ== null)) this._AverageAccelerationZ = value ? this.AverageAccelerationZ : (float?)null; }
    }
    private bool ShouldSerializeaverage_acceleration_z() { return AverageAccelerationZSpecified; }
    private void Resetaverage_acceleration_z() { AverageAccelerationZSpecified = false; }
    
    private uint? _MaxRpm;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"max_rpm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint MaxRpm
    {
      get { return _MaxRpm?? default(uint); }
      set { _MaxRpm = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool MaxRpmSpecified
    {
      get { return this._MaxRpm != null; }
      set { if (value == (this._MaxRpm== null)) this._MaxRpm = value ? this.MaxRpm : (uint?)null; }
    }
    private bool ShouldSerializemax_rpm() { return MaxRpmSpecified; }
    private void Resetmax_rpm() { MaxRpmSpecified = false; }
    
    private float? _MaxThrottlePercentage;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"max_throttle_percentage", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float MaxThrottlePercentage
    {
      get { return _MaxThrottlePercentage?? default(float); }
      set { _MaxThrottlePercentage = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool MaxThrottlePercentageSpecified
    {
      get { return this._MaxThrottlePercentage != null; }
      set { if (value == (this._MaxThrottlePercentage== null)) this._MaxThrottlePercentage = value ? this.MaxThrottlePercentage : (float?)null; }
    }
    private bool ShouldSerializemax_throttle_percentage() { return MaxThrottlePercentageSpecified; }
    private void Resetmax_throttle_percentage() { MaxThrottlePercentageSpecified = false; }
    
    private uint? _TimestampMilliseconds;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"timestamp_milliseconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint TimestampMilliseconds
    {
      get { return _TimestampMilliseconds?? default(uint); }
      set { _TimestampMilliseconds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool TimestampMillisecondsSpecified
    {
      get { return this._TimestampMilliseconds != null; }
      set { if (value == (this._TimestampMilliseconds== null)) this._TimestampMilliseconds = value ? this.TimestampMilliseconds : (uint?)null; }
    }
    private bool ShouldSerializetimestamp_milliseconds() { return TimestampMillisecondsSpecified; }
    private void Resettimestamp_milliseconds() { TimestampMillisecondsSpecified = false; }
    
    private float? _StartDirectionDegrees;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"start_direction_degrees", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float StartDirectionDegrees
    {
      get { return _StartDirectionDegrees?? default(float); }
      set { _StartDirectionDegrees = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool StartDirectionDegreesSpecified
    {
      get { return this._StartDirectionDegrees != null; }
      set { if (value == (this._StartDirectionDegrees== null)) this._StartDirectionDegrees = value ? this.StartDirectionDegrees : (float?)null; }
    }
    private bool ShouldSerializestart_direction_degrees() { return StartDirectionDegreesSpecified; }
    private void Resetstart_direction_degrees() { StartDirectionDegreesSpecified = false; }
    
    private float? _ImpactDirectionDegrees;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"impact_direction_degrees", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float ImpactDirectionDegrees
    {
      get { return _ImpactDirectionDegrees?? default(float); }
      set { _ImpactDirectionDegrees = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ImpactDirectionDegreesSpecified
    {
      get { return this._ImpactDirectionDegrees != null; }
      set { if (value == (this._ImpactDirectionDegrees== null)) this._ImpactDirectionDegrees = value ? this.ImpactDirectionDegrees : (float?)null; }
    }
    private bool ShouldSerializeimpact_direction_degrees() { return ImpactDirectionDegreesSpecified; }
    private void Resetimpact_direction_degrees() { ImpactDirectionDegreesSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}