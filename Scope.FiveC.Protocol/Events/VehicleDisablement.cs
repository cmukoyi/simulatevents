

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// VehicleDisablement event
	/// </summary>
	public partial class VehicleDisablement : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.VehicleDisablement; }
		}
	}
}
