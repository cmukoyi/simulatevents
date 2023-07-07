

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ExcessiveFreewheeling event
	/// </summary>
	public partial class ExcessiveFreewheeling : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExcessiveFreewheeling; }
		}
	}
}
