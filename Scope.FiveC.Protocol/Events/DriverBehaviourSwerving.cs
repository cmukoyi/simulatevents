

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourSwerving event
	/// </summary>
	public partial class DriverBehaviourSwerving : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourSwerving; }
		}
	}
}
