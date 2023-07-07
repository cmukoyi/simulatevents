

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourExcessiveRpm event
	/// </summary>
	public partial class DriverBehaviourExcessiveRpm : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourExcessiveRpm; }
		}
	}
}
