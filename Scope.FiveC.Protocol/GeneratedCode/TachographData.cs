//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: TachographDataProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TachographData")]
  public partial class TachographData : global::ProtoBuf.IExtensible
  {
    public TachographData()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.TachographData,
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
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}