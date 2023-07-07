

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature1Normal event
	/// </summary>
	public partial class Temperature1Normal : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature1Normal; }
		}
	}
}
