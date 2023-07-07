


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Output 3 Off event
	/// </summary>
	public partial class Output3Off : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Output3Off; }
		}
	}
}
