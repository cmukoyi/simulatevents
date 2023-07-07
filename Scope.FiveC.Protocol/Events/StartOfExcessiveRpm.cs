

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// StartOfExcessiveRpm event
	/// </summary>
	public partial class StartOfExcessiveRpm : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.StartOfExcessiveRpm; }
		}
	}
}
