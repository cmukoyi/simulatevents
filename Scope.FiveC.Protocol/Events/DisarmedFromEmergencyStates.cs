


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DisarmedFromEmergencyStates event
	/// </summary>
	public partial class DisarmedFromEmergencyStates : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DisarmedFromEmergencyStates; }
		}
	}
}
