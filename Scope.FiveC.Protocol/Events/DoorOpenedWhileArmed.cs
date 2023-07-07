


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DoorOpenedWhileArmed event
	/// </summary>
	public partial class DoorOpenedWhileArmed : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DoorOpenedWhileArmed; }
		}
	}
}
