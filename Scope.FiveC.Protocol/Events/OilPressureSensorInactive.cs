

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// OilPressureSensorInactive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class OilPressureSensorInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.OilPressureSensorInactive; }
		}
	}
}
