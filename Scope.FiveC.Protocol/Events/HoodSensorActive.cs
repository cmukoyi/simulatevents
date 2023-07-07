namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HoodSensorActive event
	/// </summary>
	public partial class HoodSensorActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HoodSensorActive; }
		}
	}
}
