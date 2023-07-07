


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GPS Navigation End event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 41</remarks>
	public partial class GpsNavigationEnd : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GpsNavigationEnd; }
		}
	}
}
