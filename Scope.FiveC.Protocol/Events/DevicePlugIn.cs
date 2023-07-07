


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DevicePlugIn event
	/// </summary>
	public partial class DevicePlugIn : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DevicePlugIn; }
		}
	}
}
