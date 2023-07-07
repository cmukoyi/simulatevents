


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// EmergencyModeByCommand event
	/// </summary>
	public partial class EmergencyModeByCommand : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.EmergencyModeByCommand; }
		}
	}
}
