


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 2 Off event
	/// </summary>
	public partial class Output2Off : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output2Off; }
		}
	}
}
