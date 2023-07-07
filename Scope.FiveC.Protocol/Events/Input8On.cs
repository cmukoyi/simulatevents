

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 8 on event
	/// </summary>
	public partial class Input8On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input8On; }
		}
	}
}
