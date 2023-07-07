


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// EngineStart event
	/// </summary>
	public partial class EngineStart : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.EngineStart; }
		}
	}
}
