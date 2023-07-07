

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Analog2Low event
	/// </summary>
	public partial class Analog2Low : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Analog2Low; }
		}
	}
}
