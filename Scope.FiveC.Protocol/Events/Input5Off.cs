

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 5 off event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 58</remarks>
	public partial class Input5Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input5Off; }
		}
	}
}
