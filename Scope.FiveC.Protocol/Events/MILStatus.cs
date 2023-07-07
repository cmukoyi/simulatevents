

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// MILStatus event
	/// </summary>
	public partial class MILStatus : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.MILStatus; }
		}
	}
}
