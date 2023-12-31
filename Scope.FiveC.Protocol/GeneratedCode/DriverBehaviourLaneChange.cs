//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: DriverBehaviourLaneChangeProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
// Note: requires additional types generated from: Enums/ForceDirectionTypeProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DriverBehaviourLaneChange")]
  public partial class DriverBehaviourLaneChange : global::ProtoBuf.IExtensible
  {
    public DriverBehaviourLaneChange()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.DriverBehaviourLaneChange,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private double? _StartLatitude;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"start_latitude", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double StartLatitude
    {
      get { return _StartLatitude?? default(double); }
      set { _StartLatitude = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool StartLatitudeSpecified
    {
      get { return this._StartLatitude != null; }
      set { if (value == (this._StartLatitude== null)) this._StartLatitude = value ? this.StartLatitude : (double?)null; }
    }
    private bool ShouldSerializestart_latitude() { return StartLatitudeSpecified; }
    private void Resetstart_latitude() { StartLatitudeSpecified = false; }
    
    private double? _StartLongitude;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"start_longitude", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double StartLongitude
    {
      get { return _StartLongitude?? default(double); }
      set { _StartLongitude = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool StartLongitudeSpecified
    {
      get { return this._StartLongitude != null; }
      set { if (value == (this._StartLongitude== null)) this._StartLongitude = value ? this.StartLongitude : (double?)null; }
    }
    private bool ShouldSerializestart_longitude() { return StartLongitudeSpecified; }
    private void Resetstart_longitude() { StartLongitudeSpecified = false; }
    
    private uint? _StartGpsStatus;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start_gps_status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint StartGpsStatus
    {
      get { return _StartGpsStatus?? default(uint); }
      set { _StartGpsStatus = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool StartGpsStatusSpecified
    {
      get { return this._StartGpsStatus != null; }
      set { if (value == (this._StartGpsStatus== null)) this._StartGpsStatus = value ? this.StartGpsStatus : (uint?)null; }
    }
    private bool ShouldSerializestart_gps_status() { return StartGpsStatusSpecified; }
    private void Resetstart_gps_status() { StartGpsStatusSpecified = false; }
    
    private uint? _StartSpeed;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"start_speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint StartSpeed
    {
      get { return _StartSpeed?? default(uint); }
      set { _StartSpeed = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool StartSpeedSpecified
    {
      get { return this._StartSpeed != null; }
      set { if (value == (this._StartSpeed== null)) this._StartSpeed = value ? this.StartSpeed : (uint?)null; }
    }
    private bool ShouldSerializestart_speed() { return StartSpeedSpecified; }
    private void Resetstart_speed() { StartSpeedSpecified = false; }
    
    private float? _SpecificMaximumAccelerometerX;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"specific_maximum_AccelerometerX", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float SpecificMaximumAccelerometerX
    {
      get { return _SpecificMaximumAccelerometerX?? default(float); }
      set { _SpecificMaximumAccelerometerX = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpecificMaximumAccelerometerXSpecified
    {
      get { return this._SpecificMaximumAccelerometerX != null; }
      set { if (value == (this._SpecificMaximumAccelerometerX== null)) this._SpecificMaximumAccelerometerX = value ? this.SpecificMaximumAccelerometerX : (float?)null; }
    }
    private bool ShouldSerializespecific_maximum_AccelerometerX() { return SpecificMaximumAccelerometerXSpecified; }
    private void Resetspecific_maximum_AccelerometerX() { SpecificMaximumAccelerometerXSpecified = false; }
    
    private float? _SpecificAverageAccelerometerX;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"specific_average_AccelerometerX", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float SpecificAverageAccelerometerX
    {
      get { return _SpecificAverageAccelerometerX?? default(float); }
      set { _SpecificAverageAccelerometerX = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpecificAverageAccelerometerXSpecified
    {
      get { return this._SpecificAverageAccelerometerX != null; }
      set { if (value == (this._SpecificAverageAccelerometerX== null)) this._SpecificAverageAccelerometerX = value ? this.SpecificAverageAccelerometerX : (float?)null; }
    }
    private bool ShouldSerializespecific_average_AccelerometerX() { return SpecificAverageAccelerometerXSpecified; }
    private void Resetspecific_average_AccelerometerX() { SpecificAverageAccelerometerXSpecified = false; }
    
    private float? _DurationSeconds;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"duration_seconds", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float DurationSeconds
    {
      get { return _DurationSeconds?? default(float); }
      set { _DurationSeconds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DurationSecondsSpecified
    {
      get { return this._DurationSeconds != null; }
      set { if (value == (this._DurationSeconds== null)) this._DurationSeconds = value ? this.DurationSeconds : (float?)null; }
    }
    private bool ShouldSerializeduration_seconds() { return DurationSecondsSpecified; }
    private void Resetduration_seconds() { DurationSecondsSpecified = false; }
    
    private uint? _DistanceMeters;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"distance_meters", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint DistanceMeters
    {
      get { return _DistanceMeters?? default(uint); }
      set { _DistanceMeters = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DistanceMetersSpecified
    {
      get { return this._DistanceMeters != null; }
      set { if (value == (this._DistanceMeters== null)) this._DistanceMeters = value ? this.DistanceMeters : (uint?)null; }
    }
    private bool ShouldSerializedistance_meters() { return DistanceMetersSpecified; }
    private void Resetdistance_meters() { DistanceMetersSpecified = false; }
    
    private float? _AccelerometerX;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"accelerometer_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"accelerometer_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"accelerometer_z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    
    private uint? _ForceDirection;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"force_direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint ForceDirection
    {
      get { return _ForceDirection?? default(uint); }
      set { _ForceDirection = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ForceDirectionSpecified
    {
      get { return this._ForceDirection != null; }
      set { if (value == (this._ForceDirection== null)) this._ForceDirection = value ? this.ForceDirection : (uint?)null; }
    }
    private bool ShouldSerializeforce_direction() { return ForceDirectionSpecified; }
    private void Resetforce_direction() { ForceDirectionSpecified = false; }
    
    private float? _ExceededAccelerometerXLimit;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"exceeded_AccelerometerX_limit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float ExceededAccelerometerXLimit
    {
      get { return _ExceededAccelerometerXLimit?? default(float); }
      set { _ExceededAccelerometerXLimit = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ExceededAccelerometerXLimitSpecified
    {
      get { return this._ExceededAccelerometerXLimit != null; }
      set { if (value == (this._ExceededAccelerometerXLimit== null)) this._ExceededAccelerometerXLimit = value ? this.ExceededAccelerometerXLimit : (float?)null; }
    }
    private bool ShouldSerializeexceeded_AccelerometerX_limit() { return ExceededAccelerometerXLimitSpecified; }
    private void Resetexceeded_AccelerometerX_limit() { ExceededAccelerometerXLimitSpecified = false; }
    
    private uint? _MaximumRpm;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"maximum_rpm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint MaximumRpm
    {
      get { return _MaximumRpm?? default(uint); }
      set { _MaximumRpm = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool MaximumRpmSpecified
    {
      get { return this._MaximumRpm != null; }
      set { if (value == (this._MaximumRpm== null)) this._MaximumRpm = value ? this.MaximumRpm : (uint?)null; }
    }
    private bool ShouldSerializemaximum_rpm() { return MaximumRpmSpecified; }
    private void Resetmaximum_rpm() { MaximumRpmSpecified = false; }
    
    private uint? _MaximumSpeed;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"maximum_speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint MaximumSpeed
    {
      get { return _MaximumSpeed?? default(uint); }
      set { _MaximumSpeed = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool MaximumSpeedSpecified
    {
      get { return this._MaximumSpeed != null; }
      set { if (value == (this._MaximumSpeed== null)) this._MaximumSpeed = value ? this.MaximumSpeed : (uint?)null; }
    }
    private bool ShouldSerializemaximum_speed() { return MaximumSpeedSpecified; }
    private void Resetmaximum_speed() { MaximumSpeedSpecified = false; }
    
    private float? _ThrottlePositionPercent;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"throttle_position_percent", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float ThrottlePositionPercent
    {
      get { return _ThrottlePositionPercent?? default(float); }
      set { _ThrottlePositionPercent = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ThrottlePositionPercentSpecified
    {
      get { return this._ThrottlePositionPercent != null; }
      set { if (value == (this._ThrottlePositionPercent== null)) this._ThrottlePositionPercent = value ? this.ThrottlePositionPercent : (float?)null; }
    }
    private bool ShouldSerializethrottle_position_percent() { return ThrottlePositionPercentSpecified; }
    private void Resetthrottle_position_percent() { ThrottlePositionPercentSpecified = false; }
    
    private uint? _OdbFlags;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"odb_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint OdbFlags
    {
      get { return _OdbFlags?? default(uint); }
      set { _OdbFlags = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool OdbFlagsSpecified
    {
      get { return this._OdbFlags != null; }
      set { if (value == (this._OdbFlags== null)) this._OdbFlags = value ? this.OdbFlags : (uint?)null; }
    }
    private bool ShouldSerializeodb_flags() { return OdbFlagsSpecified; }
    private void Resetodb_flags() { OdbFlagsSpecified = false; }
    
    private uint? _RoadSurfaceType;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"road_surface_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RoadSurfaceType
    {
      get { return _RoadSurfaceType?? default(uint); }
      set { _RoadSurfaceType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RoadSurfaceTypeSpecified
    {
      get { return this._RoadSurfaceType != null; }
      set { if (value == (this._RoadSurfaceType== null)) this._RoadSurfaceType = value ? this.RoadSurfaceType : (uint?)null; }
    }
    private bool ShouldSerializeroad_surface_type() { return RoadSurfaceTypeSpecified; }
    private void Resetroad_surface_type() { RoadSurfaceTypeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}