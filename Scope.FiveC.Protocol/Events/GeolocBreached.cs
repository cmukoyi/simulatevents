

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Periodic position event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 8, 25</remarks>
	public partial class GeolocBreached : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GeolocBreached; }
		}
	}
}
