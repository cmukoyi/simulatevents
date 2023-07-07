

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// VehicleTamper event
	/// </summary>
	public partial class VehicleTamper : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.VehicleTamper; }
		}
	}
}
