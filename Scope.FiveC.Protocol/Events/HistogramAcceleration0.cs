

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HistogramAcceleration0 event
	/// </summary>
	public partial class HistogramAcceleration0 : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HistogramAcceleration0; }
		}
	}
}
