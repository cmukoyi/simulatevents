

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourAccident event
	/// </summary>
	public partial class DriverBehaviourAccident : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourAccident; }
		}
	}
}
