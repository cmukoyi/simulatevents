

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HealthMetrics event
	/// </summary>
	public partial class HealthMetrics : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HealthMetrics; }
		}
	}
}
