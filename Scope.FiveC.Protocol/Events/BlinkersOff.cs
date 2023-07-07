

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Blinkers off event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, Command Numerator: 0x04</remarks>
	public partial class BlinkersOff : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BlinkersOff; }
		}
	}
}
