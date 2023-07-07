

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 4 on event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 71</remarks>
	public partial class Input4On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input4On; }
		}
	}
}
