


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 1 Off event
	/// </summary>
	public partial class Output1Off : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output1Off; }
		}
	}
}
