//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: CustomEvent3Proto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CustomEvent3")]
  public partial class CustomEvent3 : global::ProtoBuf.IExtensible
  {
    public CustomEvent3()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.CustomEvent3,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _Data1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data1
    {
      get { return _Data1?? default(uint); }
      set { _Data1 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data1Specified
    {
      get { return this._Data1 != null; }
      set { if (value == (this._Data1== null)) this._Data1 = value ? this.Data1 : (uint?)null; }
    }
    private bool ShouldSerializedata1() { return Data1Specified; }
    private void Resetdata1() { Data1Specified = false; }
    
    private uint? _Data2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"data2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data2
    {
      get { return _Data2?? default(uint); }
      set { _Data2 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data2Specified
    {
      get { return this._Data2 != null; }
      set { if (value == (this._Data2== null)) this._Data2 = value ? this.Data2 : (uint?)null; }
    }
    private bool ShouldSerializedata2() { return Data2Specified; }
    private void Resetdata2() { Data2Specified = false; }
    
    private uint? _Data3;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"data3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data3
    {
      get { return _Data3?? default(uint); }
      set { _Data3 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data3Specified
    {
      get { return this._Data3 != null; }
      set { if (value == (this._Data3== null)) this._Data3 = value ? this.Data3 : (uint?)null; }
    }
    private bool ShouldSerializedata3() { return Data3Specified; }
    private void Resetdata3() { Data3Specified = false; }
    
    private uint? _Data4;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"data4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data4
    {
      get { return _Data4?? default(uint); }
      set { _Data4 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data4Specified
    {
      get { return this._Data4 != null; }
      set { if (value == (this._Data4== null)) this._Data4 = value ? this.Data4 : (uint?)null; }
    }
    private bool ShouldSerializedata4() { return Data4Specified; }
    private void Resetdata4() { Data4Specified = false; }
    
    private uint? _Data5;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"data5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data5
    {
      get { return _Data5?? default(uint); }
      set { _Data5 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data5Specified
    {
      get { return this._Data5 != null; }
      set { if (value == (this._Data5== null)) this._Data5 = value ? this.Data5 : (uint?)null; }
    }
    private bool ShouldSerializedata5() { return Data5Specified; }
    private void Resetdata5() { Data5Specified = false; }
    
    private uint? _Data6;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"data6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data6
    {
      get { return _Data6?? default(uint); }
      set { _Data6 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data6Specified
    {
      get { return this._Data6 != null; }
      set { if (value == (this._Data6== null)) this._Data6 = value ? this.Data6 : (uint?)null; }
    }
    private bool ShouldSerializedata6() { return Data6Specified; }
    private void Resetdata6() { Data6Specified = false; }
    
    private uint? _Data7;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"data7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Data7
    {
      get { return _Data7?? default(uint); }
      set { _Data7 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool Data7Specified
    {
      get { return this._Data7 != null; }
      set { if (value == (this._Data7== null)) this._Data7 = value ? this.Data7 : (uint?)null; }
    }
    private bool ShouldSerializedata7() { return Data7Specified; }
    private void Resetdata7() { Data7Specified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}