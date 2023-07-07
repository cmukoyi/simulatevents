

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// I'm alive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 32</remarks>
	public partial class ImAlive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ImAlive; }
		}
	}
}
