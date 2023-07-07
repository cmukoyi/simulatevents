

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature1High event
	/// </summary>
	public partial class Temperature1High : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature1High; }
		}
	}
}
