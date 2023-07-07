

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// EngineStop event
	/// </summary>
	public partial class EngineStop : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.EngineStop; }
		}
	}
}
