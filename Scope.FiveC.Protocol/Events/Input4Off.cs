

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 4 off event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 55</remarks>
	public partial class Input4Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input4Off; }
		}
	}
}
