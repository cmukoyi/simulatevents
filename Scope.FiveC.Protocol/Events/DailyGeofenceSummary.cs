

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DailyGeofenceSummary event
	/// </summary>
	public partial class DailyGeofenceSummary : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DailyGeofenceSummary; }
		}
	}
}
