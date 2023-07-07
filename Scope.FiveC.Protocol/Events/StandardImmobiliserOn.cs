

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// StandardImmobiliserOn event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, CommandNumerator: 0x15</remarks>
	public partial class StandardImmobiliserOn : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.StandardImmobiliserOn; }
		}
	}
}
