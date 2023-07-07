


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 4 Off event
	/// </summary>
	public partial class Output4Off : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output4Off; }
		}
	}
}
