

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// WaterTemperatureSensorInactive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class WaterTemperatureSensorInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.WaterTemperatureSensorInactive; }
		}
	}
}
