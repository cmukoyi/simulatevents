


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DeviceRemoval event
	/// </summary>
	public partial class DeviceRemoval : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DeviceRemoval; }
		}
	}
}
