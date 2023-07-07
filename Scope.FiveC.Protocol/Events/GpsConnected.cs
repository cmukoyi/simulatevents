

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GPS connected event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 27</remarks>
	public partial class GpsConnected : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GpsConnected; }
		}
	}
}
