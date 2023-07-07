

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature3Low event
	/// </summary>
	public partial class Temperature3Low : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature3Low; }
		}
	}
}
