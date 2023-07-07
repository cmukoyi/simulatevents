

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// IdleSpeedStart event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class IdleSpeedStart : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.IdleSpeedStart; }
		}
	}
}
