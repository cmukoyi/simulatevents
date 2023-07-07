

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourAcceleration event
	/// </summary>
	public partial class DriverBehaviourAcceleration : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourAcceleration; }
		}
	}
}
