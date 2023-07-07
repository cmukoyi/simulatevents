//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: FuelLevelProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FuelLevel")]
  public partial class FuelLevel : global::ProtoBuf.IExtensible
  {
    public FuelLevel()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.FuelLevel,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _MilStatus;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mil_status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint MilStatus
    {
      get { return _MilStatus?? default(uint); }
      set { _MilStatus = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool MilStatusSpecified
    {
      get { return this._MilStatus != null; }
      set { if (value == (this._MilStatus== null)) this._MilStatus = value ? this.MilStatus : (uint?)null; }
    }
    private bool ShouldSerializemil_status() { return MilStatusSpecified; }
    private void Resetmil_status() { MilStatusSpecified = false; }
    
    private uint? _Rpm;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rpm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private uint? _ThrottlePosition;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"throttle_position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint ThrottlePosition
    {
      get { return _ThrottlePosition?? default(uint); }
      set { _ThrottlePosition = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ThrottlePositionSpecified
    {
      get { return this._ThrottlePosition != null; }
      set { if (value == (this._ThrottlePosition== null)) this._ThrottlePosition = value ? this.ThrottlePosition : (uint?)null; }
    }
    private bool ShouldSerializethrottle_position() { return ThrottlePositionSpecified; }
    private void Resetthrottle_position() { ThrottlePositionSpecified = false; }
    
    private uint? _EngineLoadValue;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"engine_load_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EngineLoadValue
    {
      get { return _EngineLoadValue?? default(uint); }
      set { _EngineLoadValue = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool EngineLoadValueSpecified
    {
      get { return this._EngineLoadValue != null; }
      set { if (value == (this._EngineLoadValue== null)) this._EngineLoadValue = value ? this.EngineLoadValue : (uint?)null; }
    }
    private bool ShouldSerializeengine_load_value() { return EngineLoadValueSpecified; }
    private void Resetengine_load_value() { EngineLoadValueSpecified = false; }
    
    private uint? _EngineLoadLimit;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"engine_load_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EngineLoadLimit
    {
      get { return _EngineLoadLimit?? default(uint); }
      set { _EngineLoadLimit = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool EngineLoadLimitSpecified
    {
      get { return this._EngineLoadLimit != null; }
      set { if (value == (this._EngineLoadLimit== null)) this._EngineLoadLimit = value ? this.EngineLoadLimit : (uint?)null; }
    }
    private bool ShouldSerializeengine_load_limit() { return EngineLoadLimitSpecified; }
    private void Resetengine_load_limit() { EngineLoadLimitSpecified = false; }
    
    private uint? _EngineLoadTimeLimit;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"engine_load_time_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EngineLoadTimeLimit
    {
      get { return _EngineLoadTimeLimit?? default(uint); }
      set { _EngineLoadTimeLimit = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool EngineLoadTimeLimitSpecified
    {
      get { return this._EngineLoadTimeLimit != null; }
      set { if (value == (this._EngineLoadTimeLimit== null)) this._EngineLoadTimeLimit = value ? this.EngineLoadTimeLimit : (uint?)null; }
    }
    private bool ShouldSerializeengine_load_time_limit() { return EngineLoadTimeLimitSpecified; }
    private void Resetengine_load_time_limit() { EngineLoadTimeLimitSpecified = false; }
    
    private int? _EngineCoolantTemperature;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"engine_coolant_temperature", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int EngineCoolantTemperature
    {
      get { return _EngineCoolantTemperature?? default(int); }
      set { _EngineCoolantTemperature = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool EngineCoolantTemperatureSpecified
    {
      get { return this._EngineCoolantTemperature != null; }
      set { if (value == (this._EngineCoolantTemperature== null)) this._EngineCoolantTemperature = value ? this.EngineCoolantTemperature : (int?)null; }
    }
    private bool ShouldSerializeengine_coolant_temperature() { return EngineCoolantTemperatureSpecified; }
    private void Resetengine_coolant_temperature() { EngineCoolantTemperatureSpecified = false; }
    
    private uint? _EngineCoolantTemperatureLimit;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"engine_coolant_temperature_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EngineCoolantTemperatureLimit
    {
      get { return _EngineCoolantTemperatureLimit?? default(uint); }
      set { _EngineCoolantTemperatureLimit = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool EngineCoolantTemperatureLimitSpecified
    {
      get { return this._EngineCoolantTemperatureLimit != null; }
      set { if (value == (this._EngineCoolantTemperatureLimit== null)) this._EngineCoolantTemperatureLimit = value ? this.EngineCoolantTemperatureLimit : (uint?)null; }
    }
    private bool ShouldSerializeengine_coolant_temperature_limit() { return EngineCoolantTemperatureLimitSpecified; }
    private void Resetengine_coolant_temperature_limit() { EngineCoolantTemperatureLimitSpecified = false; }
    
    private uint? _FuelLevelValue;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"fuel_level_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint FuelLevelValue
    {
      get { return _FuelLevelValue?? default(uint); }
      set { _FuelLevelValue = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool FuelLevelValueSpecified
    {
      get { return this._FuelLevelValue != null; }
      set { if (value == (this._FuelLevelValue== null)) this._FuelLevelValue = value ? this.FuelLevelValue : (uint?)null; }
    }
    private bool ShouldSerializefuel_level_value() { return FuelLevelValueSpecified; }
    private void Resetfuel_level_value() { FuelLevelValueSpecified = false; }
    
    private uint? _FuelLevelLowLimit;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"fuel_level_low_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint FuelLevelLowLimit
    {
      get { return _FuelLevelLowLimit?? default(uint); }
      set { _FuelLevelLowLimit = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool FuelLevelLowLimitSpecified
    {
      get { return this._FuelLevelLowLimit != null; }
      set { if (value == (this._FuelLevelLowLimit== null)) this._FuelLevelLowLimit = value ? this.FuelLevelLowLimit : (uint?)null; }
    }
    private bool ShouldSerializefuel_level_low_limit() { return FuelLevelLowLimitSpecified; }
    private void Resetfuel_level_low_limit() { FuelLevelLowLimitSpecified = false; }
    
    private uint? _InstantaneousFuelEconomy;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"instantaneous_fuel_economy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint InstantaneousFuelEconomy
    {
      get { return _InstantaneousFuelEconomy?? default(uint); }
      set { _InstantaneousFuelEconomy = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool InstantaneousFuelEconomySpecified
    {
      get { return this._InstantaneousFuelEconomy != null; }
      set { if (value == (this._InstantaneousFuelEconomy== null)) this._InstantaneousFuelEconomy = value ? this.InstantaneousFuelEconomy : (uint?)null; }
    }
    private bool ShouldSerializeinstantaneous_fuel_economy() { return InstantaneousFuelEconomySpecified; }
    private void Resetinstantaneous_fuel_economy() { InstantaneousFuelEconomySpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}