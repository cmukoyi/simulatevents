

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature2High event
	/// </summary>
	public partial class Temperature2High : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature2High; }
		}
	}
}
