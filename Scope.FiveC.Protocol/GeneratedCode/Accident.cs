//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: AccidentProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Accident")]
  public partial class Accident : global::ProtoBuf.IExtensible
  {
    public Accident()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.Accident,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _ImpactDirection;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"impact_direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint ImpactDirection
    {
      get { return _ImpactDirection?? default(uint); }
      set { _ImpactDirection = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ImpactDirectionSpecified
    {
      get { return this._ImpactDirection != null; }
      set { if (value == (this._ImpactDirection== null)) this._ImpactDirection = value ? this.ImpactDirection : (uint?)null; }
    }
    private bool ShouldSerializeimpact_direction() { return ImpactDirectionSpecified; }
    private void Resetimpact_direction() { ImpactDirectionSpecified = false; }
    
    private float? _AccelerometerX;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"accelerometer_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"accelerometer_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"accelerometer_z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    
    private uint? _GforcelimitX;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"gforcelimit_x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint GforcelimitX
    {
      get { return _GforcelimitX?? default(uint); }
      set { _GforcelimitX = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool GforcelimitXSpecified
    {
      get { return this._GforcelimitX != null; }
      set { if (value == (this._GforcelimitX== null)) this._GforcelimitX = value ? this.GforcelimitX : (uint?)null; }
    }
    private bool ShouldSerializegforcelimit_x() { return GforcelimitXSpecified; }
    private void Resetgforcelimit_x() { GforcelimitXSpecified = false; }
    
    private uint? _GforcelimitY;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"gforcelimit_y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint GforcelimitY
    {
      get { return _GforcelimitY?? default(uint); }
      set { _GforcelimitY = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool GforcelimitYSpecified
    {
      get { return this._GforcelimitY != null; }
      set { if (value == (this._GforcelimitY== null)) this._GforcelimitY = value ? this.GforcelimitY : (uint?)null; }
    }
    private bool ShouldSerializegforcelimit_y() { return GforcelimitYSpecified; }
    private void Resetgforcelimit_y() { GforcelimitYSpecified = false; }
    
    private uint? _AccidentReconIndex;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"accident_recon_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}