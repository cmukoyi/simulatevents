

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Door close event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 48</remarks>
	public partial class DoorClose : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DoorClose; }
		}
	}
}
