

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ExcessiveIdle event
	/// </summary>
	public partial class ExcessiveIdle : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExcessiveIdle; }
		}
	}
}
