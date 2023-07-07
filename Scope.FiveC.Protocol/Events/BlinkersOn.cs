

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Blinkers on event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, Command Numerator: 0x14</remarks>
	public partial class BlinkersOn : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BlinkersOn; }
		}
	}
}
