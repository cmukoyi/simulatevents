

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ServiceNotify event
	/// </summary>
	public partial class ServiceNotify : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ServiceNotify; }
		}
	}
}
