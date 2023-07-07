

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ShockSensorInactive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 49</remarks>
	public partial class ShockSensorInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ShockSensorInactive; }
		}
	}
}
