

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// RecklessDriving event
	/// </summary>
	public partial class RecklessDriving : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.RecklessDriving; }
		}
	}
}
