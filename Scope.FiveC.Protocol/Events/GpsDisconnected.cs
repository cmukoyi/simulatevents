

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GPS disconnected event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 7</remarks>
	public partial class GpsDisconnected : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GpsDisconnected; }
		}
	}
}
