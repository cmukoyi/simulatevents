


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// EngineActivatedWhileArmed event
	/// </summary>
	public partial class EngineActivatedWhileArmed : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.EngineActivatedWhileArmed; }
		}
	}
}
