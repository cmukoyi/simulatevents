//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: TripAnalysisProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TripAnalysis")]
  public partial class TripAnalysis : global::ProtoBuf.IExtensible
  {
    public TripAnalysis()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.TripAnalysis,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _RpmBand1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rpm_band1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand1
    {
      get { return _RpmBand1?? default(uint); }
      set { _RpmBand1 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand1Specified
    {
      get { return this._RpmBand1 != null; }
      set { if (value == (this._RpmBand1== null)) this._RpmBand1 = value ? this.RpmBand1 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band1() { return RpmBand1Specified; }
    private void Resetrpm_band1() { RpmBand1Specified = false; }
    
    private uint? _RpmBand2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rpm_band2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand2
    {
      get { return _RpmBand2?? default(uint); }
      set { _RpmBand2 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand2Specified
    {
      get { return this._RpmBand2 != null; }
      set { if (value == (this._RpmBand2== null)) this._RpmBand2 = value ? this.RpmBand2 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band2() { return RpmBand2Specified; }
    private void Resetrpm_band2() { RpmBand2Specified = false; }
    
    private uint? _RpmBand3;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rpm_band3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand3
    {
      get { return _RpmBand3?? default(uint); }
      set { _RpmBand3 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand3Specified
    {
      get { return this._RpmBand3 != null; }
      set { if (value == (this._RpmBand3== null)) this._RpmBand3 = value ? this.RpmBand3 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band3() { return RpmBand3Specified; }
    private void Resetrpm_band3() { RpmBand3Specified = false; }
    
    private uint? _RpmBand4;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rpm_band4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand4
    {
      get { return _RpmBand4?? default(uint); }
      set { _RpmBand4 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand4Specified
    {
      get { return this._RpmBand4 != null; }
      set { if (value == (this._RpmBand4== null)) this._RpmBand4 = value ? this.RpmBand4 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band4() { return RpmBand4Specified; }
    private void Resetrpm_band4() { RpmBand4Specified = false; }
    
    private uint? _RpmBand5;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"rpm_band5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand5
    {
      get { return _RpmBand5?? default(uint); }
      set { _RpmBand5 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand5Specified
    {
      get { return this._RpmBand5 != null; }
      set { if (value == (this._RpmBand5== null)) this._RpmBand5 = value ? this.RpmBand5 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band5() { return RpmBand5Specified; }
    private void Resetrpm_band5() { RpmBand5Specified = false; }
    
    private uint? _RpmBand6;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"rpm_band6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand6
    {
      get { return _RpmBand6?? default(uint); }
      set { _RpmBand6 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand6Specified
    {
      get { return this._RpmBand6 != null; }
      set { if (value == (this._RpmBand6== null)) this._RpmBand6 = value ? this.RpmBand6 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band6() { return RpmBand6Specified; }
    private void Resetrpm_band6() { RpmBand6Specified = false; }
    
    private uint? _RpmBand7;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"rpm_band7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand7
    {
      get { return _RpmBand7?? default(uint); }
      set { _RpmBand7 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand7Specified
    {
      get { return this._RpmBand7 != null; }
      set { if (value == (this._RpmBand7== null)) this._RpmBand7 = value ? this.RpmBand7 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band7() { return RpmBand7Specified; }
    private void Resetrpm_band7() { RpmBand7Specified = false; }
    
    private uint? _RpmBand8;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"rpm_band8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand8
    {
      get { return _RpmBand8?? default(uint); }
      set { _RpmBand8 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand8Specified
    {
      get { return this._RpmBand8 != null; }
      set { if (value == (this._RpmBand8== null)) this._RpmBand8 = value ? this.RpmBand8 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band8() { return RpmBand8Specified; }
    private void Resetrpm_band8() { RpmBand8Specified = false; }
    
    private uint? _RpmBand9;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"rpm_band9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RpmBand9
    {
      get { return _RpmBand9?? default(uint); }
      set { _RpmBand9 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool RpmBand9Specified
    {
      get { return this._RpmBand9 != null; }
      set { if (value == (this._RpmBand9== null)) this._RpmBand9 = value ? this.RpmBand9 : (uint?)null; }
    }
    private bool ShouldSerializerpm_band9() { return RpmBand9Specified; }
    private void Resetrpm_band9() { RpmBand9Specified = false; }
    
    private uint? _SpeedBand1;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"speed_band1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"speed_band2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"speed_band3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"speed_band4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"speed_band5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"speed_band6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"speed_band7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"speed_band8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private uint? _SpeedBand9;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"speed_band9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint SpeedBand9
    {
      get { return _SpeedBand9?? default(uint); }
      set { _SpeedBand9 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool SpeedBand9Specified
    {
      get { return this._SpeedBand9 != null; }
      set { if (value == (this._SpeedBand9== null)) this._SpeedBand9 = value ? this.SpeedBand9 : (uint?)null; }
    }
    private bool ShouldSerializespeed_band9() { return SpeedBand9Specified; }
    private void Resetspeed_band9() { SpeedBand9Specified = false; }
    
    private uint? _DrivingTime;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"driving_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint DrivingTime
    {
      get { return _DrivingTime?? default(uint); }
      set { _DrivingTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DrivingTimeSpecified
    {
      get { return this._DrivingTime != null; }
      set { if (value == (this._DrivingTime== null)) this._DrivingTime = value ? this.DrivingTime : (uint?)null; }
    }
    private bool ShouldSerializedriving_time() { return DrivingTimeSpecified; }
    private void Resetdriving_time() { DrivingTimeSpecified = false; }
    
    private uint? _IdleTime;
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"idle_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint IdleTime
    {
      get { return _IdleTime?? default(uint); }
      set { _IdleTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool IdleTimeSpecified
    {
      get { return this._IdleTime != null; }
      set { if (value == (this._IdleTime== null)) this._IdleTime = value ? this.IdleTime : (uint?)null; }
    }
    private bool ShouldSerializeidle_time() { return IdleTimeSpecified; }
    private void Resetidle_time() { IdleTimeSpecified = false; }
    
    private uint? _PtoTime;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"pto_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint PtoTime
    {
      get { return _PtoTime?? default(uint); }
      set { _PtoTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool PtoTimeSpecified
    {
      get { return this._PtoTime != null; }
      set { if (value == (this._PtoTime== null)) this._PtoTime = value ? this.PtoTime : (uint?)null; }
    }
    private bool ShouldSerializepto_time() { return PtoTimeSpecified; }
    private void Resetpto_time() { PtoTimeSpecified = false; }
    
    private uint? _DrivingFuel;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"driving_fuel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint DrivingFuel
    {
      get { return _DrivingFuel?? default(uint); }
      set { _DrivingFuel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DrivingFuelSpecified
    {
      get { return this._DrivingFuel != null; }
      set { if (value == (this._DrivingFuel== null)) this._DrivingFuel = value ? this.DrivingFuel : (uint?)null; }
    }
    private bool ShouldSerializedriving_fuel() { return DrivingFuelSpecified; }
    private void Resetdriving_fuel() { DrivingFuelSpecified = false; }
    
    private uint? _IdleFuel;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"idle_fuel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint IdleFuel
    {
      get { return _IdleFuel?? default(uint); }
      set { _IdleFuel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool IdleFuelSpecified
    {
      get { return this._IdleFuel != null; }
      set { if (value == (this._IdleFuel== null)) this._IdleFuel = value ? this.IdleFuel : (uint?)null; }
    }
    private bool ShouldSerializeidle_fuel() { return IdleFuelSpecified; }
    private void Resetidle_fuel() { IdleFuelSpecified = false; }
    
    private uint? _PtoFuel;
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"pto_fuel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint PtoFuel
    {
      get { return _PtoFuel?? default(uint); }
      set { _PtoFuel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool PtoFuelSpecified
    {
      get { return this._PtoFuel != null; }
      set { if (value == (this._PtoFuel== null)) this._PtoFuel = value ? this.PtoFuel : (uint?)null; }
    }
    private bool ShouldSerializepto_fuel() { return PtoFuelSpecified; }
    private void Resetpto_fuel() { PtoFuelSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}