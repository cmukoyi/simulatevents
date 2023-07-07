

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// PulseCount event
	/// </summary>
	public partial class PulseCount : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.PulseCount; }
		}
	}
}
