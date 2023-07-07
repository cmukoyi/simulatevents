

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// TripStartup event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 69</remarks>
	public partial class TripStartup : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.TripStartup; }
		}
	}
}
