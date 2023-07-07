

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature3High event
	/// </summary>
	public partial class Temperature3High : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature3High; }
		}
	}
}
