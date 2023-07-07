

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HistogramSpeed event
	/// </summary>
	public partial class HistogramSpeed : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HistogramSpeed; }
		}
	}
}
