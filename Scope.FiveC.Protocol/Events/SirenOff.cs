

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// SirenOff event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, CommandNumerator: 0x00</remarks>
	public partial class SirenOff : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.SirenOff; }
		}
	}
}
