

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// External immobiliser off event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, Command Numerator: 0x03</remarks>
	public partial class ExternalImmobiliserOff : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExternalImmobiliserOff; }
		}
	}
}
