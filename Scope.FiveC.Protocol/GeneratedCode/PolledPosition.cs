//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: PolledPositionProto.proto
// Note: requires additional types generated from: EventHeaderProto.proto
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PolledPosition")]
  public partial class PolledPosition : global::ProtoBuf.IExtensible
  {
    public PolledPosition()
	{
		_Header = new EventHeader
		{
			TemplateId = (uint) ProtocolBufferTemplate.PolledPosition,
		};
	}
    
    private EventHeader _Header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public override EventHeader Header
    {
      get { return _Header; }
      set { _Header = value; }
    }
    private uint? _TripDistanceMeters;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"trip_distance_meters", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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