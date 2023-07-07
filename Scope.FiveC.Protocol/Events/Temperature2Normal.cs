

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature2Normal event
	/// </summary>
	public partial class Temperature2Normal : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature2Normal; }
		}
	}
}
