

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Analog2High event
	/// </summary>
	public partial class Analog2High : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Analog2High; }
		}
	}
}
