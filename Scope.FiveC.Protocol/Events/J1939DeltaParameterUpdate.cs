


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939DeltaParameterUpdate event
	/// </summary>
	public partial class J1939DeltaParameterUpdate : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939DeltaParameterUpdate; }
		}
	}
}
