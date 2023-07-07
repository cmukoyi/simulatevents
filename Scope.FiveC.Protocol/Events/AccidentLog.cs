


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Accident log event
	/// </summary>
	public partial class AccidentLog : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentLog; }
		}
	}
}
