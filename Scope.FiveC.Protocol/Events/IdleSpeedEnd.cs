

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// IdleSpeedEnd event
	/// </summary>
	public partial class IdleSpeedEnd : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.IdleSpeedEnd; }
		}
	}
}
