//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: CustomCANDataProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CustomCANData")]
  public partial class CustomCANData : global::ProtoBuf.IExtensible
  {
    public CustomCANData()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.CustomCANData,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _CustomJ1939Pgn0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"custom_j1939_pgn0", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint CustomJ1939Pgn0
    {
      get { return _CustomJ1939Pgn0?? default(uint); }
      set { _CustomJ1939Pgn0 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool CustomJ1939Pgn0Specified
    {
      get { return this._CustomJ1939Pgn0 != null; }
      set { if (value == (this._CustomJ1939Pgn0== null)) this._CustomJ1939Pgn0 = value ? this.CustomJ1939Pgn0 : (uint?)null; }
    }
    private bool ShouldSerializecustom_j1939_pgn0() { return CustomJ1939Pgn0Specified; }
    private void Resetcustom_j1939_pgn0() { CustomJ1939Pgn0Specified = false; }
    
    private uint? _CanMessage0Byte03;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"can_message_0_byte_0_3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint CanMessage0Byte03
    {
      get { return _CanMessage0Byte03?? default(uint); }
      set { _CanMessage0Byte03 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool CanMessage0Byte03Specified
    {
      get { return this._CanMessage0Byte03 != null; }
      set { if (value == (this._CanMessage0Byte03== null)) this._CanMessage0Byte03 = value ? this.CanMessage0Byte03 : (uint?)null; }
    }
    private bool ShouldSerializecan_message_0_byte_0_3() { return CanMessage0Byte03Specified; }
    private void Resetcan_message_0_byte_0_3() { CanMessage0Byte03Specified = false; }
    
    private uint? _CanMessage0Byte47;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"can_message_0_byte_4_7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint CanMessage0Byte47
    {
      get { return _CanMessage0Byte47?? default(uint); }
      set { _CanMessage0Byte47 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool CanMessage0Byte47Specified
    {
      get { return this._CanMessage0Byte47 != null; }
      set { if (value == (this._CanMessage0Byte47== null)) this._CanMessage0Byte47 = value ? this.CanMessage0Byte47 : (uint?)null; }
    }
    private bool ShouldSerializecan_message_0_byte_4_7() { return CanMessage0Byte47Specified; }
    private void Resetcan_message_0_byte_4_7() { CanMessage0Byte47Specified = false; }
    
    private uint? _CustomJ1939Pgn1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"custom_j1939_pgn1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint CustomJ1939Pgn1
    {
      get { return _CustomJ1939Pgn1?? default(uint); }
      set { _CustomJ1939Pgn1 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool CustomJ1939Pgn1Specified
    {
      get { return this._CustomJ1939Pgn1 != null; }
      set { if (value == (this._CustomJ1939Pgn1== null)) this._CustomJ1939Pgn1 = value ? this.CustomJ1939Pgn1 : (uint?)null; }
    }
    private bool ShouldSerializecustom_j1939_pgn1() { return CustomJ1939Pgn1Specified; }
    private void Resetcustom_j1939_pgn1() { CustomJ1939Pgn1Specified = false; }
    
    private uint? _CanMessage1Byte03;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"can_message_1_byte_0_3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint CanMessage1Byte03
    {
      get { return _CanMessage1Byte03?? default(uint); }
      set { _CanMessage1Byte03 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool CanMessage1Byte03Specified
    {
      get { return this._CanMessage1Byte03 != null; }
      set { if (value == (this._CanMessage1Byte03== null)) this._CanMessage1Byte03 = value ? this.CanMessage1Byte03 : (uint?)null; }
    }
    private bool ShouldSerializecan_message_1_byte_0_3() { return CanMessage1Byte03Specified; }
    private void Resetcan_message_1_byte_0_3() { CanMessage1Byte03Specified = false; }
    
    private uint? _CanMessage1Byte47;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"can_message_1_byte_4_7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint CanMessage1Byte47
    {
      get { return _CanMessage1Byte47?? default(uint); }
      set { _CanMessage1Byte47 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool CanMessage1Byte47Specified
    {
      get { return this._CanMessage1Byte47 != null; }
      set { if (value == (this._CanMessage1Byte47== null)) this._CanMessage1Byte47 = value ? this.CanMessage1Byte47 : (uint?)null; }
    }
    private bool ShouldSerializecan_message_1_byte_4_7() { return CanMessage1Byte47Specified; }
    private void Resetcan_message_1_byte_4_7() { CanMessage1Byte47Specified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}