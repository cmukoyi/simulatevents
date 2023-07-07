

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// MovementStart event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class MovementStart : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.MovementStart; }
		}
	}
}
