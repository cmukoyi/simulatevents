

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HistogramAcceleration1 event
	/// </summary>
	public partial class HistogramAcceleration1 : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HistogramAcceleration1; }
		}
	}
}
