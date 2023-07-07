


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 2 On event
	/// </summary>
	public partial class Output2On : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output2On; }
		}
	}
}
