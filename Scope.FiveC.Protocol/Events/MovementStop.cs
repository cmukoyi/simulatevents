

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// MovementStop event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class MovementStop : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.MovementStop; }
		}
	}
}
