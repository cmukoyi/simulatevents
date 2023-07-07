

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// CanVehicleInfo event
	/// </summary>
	public partial class CanVehicleInfo : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.CanVehicleInfo; }
		}
	}
}
