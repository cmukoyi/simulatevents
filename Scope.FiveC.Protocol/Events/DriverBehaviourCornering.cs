

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourCornering event
	/// </summary>
	public partial class DriverBehaviourCornering : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourCornering; }
		}
	}
}
