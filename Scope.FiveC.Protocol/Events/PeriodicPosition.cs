

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Periodic position event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 36, 44, 100</remarks>
	public partial class PeriodicPosition : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.PeriodicPosition; }
		}
	}
}
