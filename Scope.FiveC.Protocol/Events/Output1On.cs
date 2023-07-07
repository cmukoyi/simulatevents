


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 1 On event
	/// </summary>
	public partial class Output1On : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output1On; }
		}
	}
}
