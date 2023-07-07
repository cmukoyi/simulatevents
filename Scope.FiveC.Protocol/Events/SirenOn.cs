

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// SirenOn event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 31, Initiative: True, CommandNumerator: 0x10</remarks>
	public partial class SirenOn : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.SirenOn; }
		}
	}
}
