

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DailyTripSummary event
	/// </summary>
	public partial class DailyTripSummary : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DailyTripSummary; }
		}
	}
}
