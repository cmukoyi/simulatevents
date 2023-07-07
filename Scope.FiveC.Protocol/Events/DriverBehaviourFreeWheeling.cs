

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourFreeWheeling event
	/// </summary>
	public partial class DriverBehaviourFreeWheeling : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourFreeWheeling; }
		}
	}
}
