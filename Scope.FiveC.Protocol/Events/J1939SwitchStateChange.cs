


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939SwitchStateChange event
	/// </summary>
	public partial class J1939SwitchStateChange : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939SwitchStateChange; }
		}
	}
}
