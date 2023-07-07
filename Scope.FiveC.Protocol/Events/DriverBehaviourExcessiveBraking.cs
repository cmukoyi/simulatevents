

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourExcessiveBraking event
	/// </summary>
	public partial class DriverBehaviourExcessiveBraking : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourExcessiveBraking; }
		}
	}
}
