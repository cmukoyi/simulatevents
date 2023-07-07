

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// InputCounters event
	/// </summary>
	public partial class InputCounters : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.InputCounters; }
		}
	}
}
