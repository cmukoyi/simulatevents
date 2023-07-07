

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// VehicleVIN event
	/// </summary>
	public partial class VehicleVIN : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.VehicleVIN; }
		}
	}
}
