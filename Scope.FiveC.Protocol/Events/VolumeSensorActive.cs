

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// VolumeSensorActive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class VolumeSensorActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.VolumeSensorActive; }
		}
	}
}
