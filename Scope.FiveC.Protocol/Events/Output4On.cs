


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 4 On event
	/// </summary>
	public partial class Output4On : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output4On; }
		}
	}
}
