using Scope.FiveC.Protocol.Events.Enums;


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourSpeeding event
	/// </summary>
	public partial class DriverBehaviourSpeeding : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourSpeeding; }
		}
	}
}
