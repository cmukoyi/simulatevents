

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverBehaviourExcessiveIdle event
	/// </summary>
	public partial class DriverBehaviourExcessiveIdle : DriverBehaviourEventBase, IDriverBehaviourEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverBehaviourExcessiveIdle; }
		}
	}
}
