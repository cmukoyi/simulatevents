

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// TripSummary event
	/// </summary>
	public partial class TripSummary : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.TripSummary; }
		}
	}
}
