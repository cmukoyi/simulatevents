

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GsmNotice event
	/// </summary>
	public partial class GsmNotice : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GsmNotice; }
		}
	}
}
