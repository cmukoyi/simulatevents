

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 5 on event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 74</remarks>
	public partial class Input5On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input5On; }
		}
	}
}
