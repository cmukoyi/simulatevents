

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// A requested (polled) position event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, CommandNumerator: 0xFF</remarks>
	public partial class PolledPosition : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.PolledPosition; }
		}
	}
}
