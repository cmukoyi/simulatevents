

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// OilPressureSensorActive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class OilPressureSensorActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.OilPressureSensorActive; }
		}
	}
}
