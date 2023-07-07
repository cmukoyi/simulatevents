

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Harsh braking event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 99</remarks>
	public partial class HarshBraking : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HarshBraking; }
		}
	}
}
