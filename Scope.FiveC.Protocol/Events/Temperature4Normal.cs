

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature4Normal event
	/// </summary>
	public partial class Temperature4Normal : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature4Normal; }
		}
	}
}
