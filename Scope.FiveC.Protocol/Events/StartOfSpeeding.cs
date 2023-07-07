

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// StartOfSpeeding event
	/// </summary>
	public partial class StartOfSpeeding : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.StartOfSpeeding; }
		}
	}
}
