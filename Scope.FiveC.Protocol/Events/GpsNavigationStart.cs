


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GPS Navigation Start event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 33</remarks>
	public partial class GpsNavigationStart : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GpsNavigationStart; }
		}
	}
}
