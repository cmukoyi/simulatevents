

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature4Low event
	/// </summary>
	public partial class Temperature4Low : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature4Low; }
		}
	}
}
