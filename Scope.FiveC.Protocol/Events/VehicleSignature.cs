

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// VehicleSignature event
	/// </summary>
	public partial class VehicleSignature : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.VehicleSignature; }
		}
	}
}
