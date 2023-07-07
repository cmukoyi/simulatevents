

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// StandardImmobiliserOff event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, CommandNumerator: 0x05</remarks>
	public partial class StandardImmobiliserOff : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.StandardImmobiliserOff; }
		}
	}
}
