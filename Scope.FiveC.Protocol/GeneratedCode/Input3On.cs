//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: Input3OnProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Input3On")]
  public partial class Input3On : global::ProtoBuf.IExtensible
  {
    public Input3On()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.Input3On,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _DurationSeconds;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"duration_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint DurationSeconds
    {
      get { return _DurationSeconds?? default(uint); }
      set { _DurationSeconds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DurationSecondsSpecified
    {
      get { return this._DurationSeconds != null; }
      set { if (value == (this._DurationSeconds== null)) this._DurationSeconds = value ? this.DurationSeconds : (uint?)null; }
    }
    private bool ShouldSerializeduration_seconds() { return DurationSecondsSpecified; }
    private void Resetduration_seconds() { DurationSecondsSpecified = false; }
    
    private uint? _DelaySeconds;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"delay_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint DelaySeconds
    {
      get { return _DelaySeconds?? default(uint); }
      set { _DelaySeconds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool DelaySecondsSpecified
    {
      get { return this._DelaySeconds != null; }
      set { if (value == (this._DelaySeconds== null)) this._DelaySeconds = value ? this.DelaySeconds : (uint?)null; }
    }
    private bool ShouldSerializedelay_seconds() { return DelaySecondsSpecified; }
    private void Resetdelay_seconds() { DelaySecondsSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}