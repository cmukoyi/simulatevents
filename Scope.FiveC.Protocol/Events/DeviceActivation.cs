


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DeviceActivation event
	/// </summary>
	public partial class DeviceActivation : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DeviceActivation; }
		}
	}
}
