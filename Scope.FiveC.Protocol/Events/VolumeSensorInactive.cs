

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// VolumeSensorInactive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class VolumeSensorInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.VolumeSensorInactive; }
		}
	}
}
