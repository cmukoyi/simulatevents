

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature4High event
	/// </summary>
	public partial class Temperature4High : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature4High; }
		}
	}
}
