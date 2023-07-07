

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourLaneChange event
	/// </summary>
	public partial class DriverBehaviourLaneChange : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourLaneChange; }
		}
	}
}
