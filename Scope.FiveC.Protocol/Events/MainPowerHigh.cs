

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Main power high event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 87, 88</remarks>
	public partial class MainPowerHigh : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.MainPowerHigh; }
		}
	}
}
