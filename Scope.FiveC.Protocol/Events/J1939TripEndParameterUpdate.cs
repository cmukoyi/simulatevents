


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939TripEndParameterUpdate event
	/// </summary>
	public partial class J1939TripEndParameterUpdate : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939TripEndParameterUpdate; }
		}
	}
}
