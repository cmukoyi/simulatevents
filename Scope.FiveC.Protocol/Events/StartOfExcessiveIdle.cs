

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// StartOfExcessiveIdle event
	/// </summary>
	public partial class StartOfExcessiveIdle : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.StartOfExcessiveIdle; }
		}
	}
}
