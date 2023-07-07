


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939TripStartParameterUpdate event
	/// </summary>
	public partial class J1939TripStartParameterUpdate : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939TripStartParameterUpdate; }
		}
	}
}
