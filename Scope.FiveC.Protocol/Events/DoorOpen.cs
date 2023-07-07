

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Door open event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 64</remarks>
	public partial class DoorOpen : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DoorOpen; }
		}
	}
}
