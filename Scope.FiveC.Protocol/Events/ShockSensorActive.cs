

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ShockSensorActive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 65</remarks>
	public partial class ShockSensorActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ShockSensorActive; }
		}
	}
}
