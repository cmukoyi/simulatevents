

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature2Low event
	/// </summary>
	public partial class Temperature2Low : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature2Low; }
		}
	}
}
