

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// External immobiliser on event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, Command Numerator: 0x13</remarks>
	public partial class ExternalImmobiliserOn : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExternalImmobiliserOn; }
		}
	}
}
