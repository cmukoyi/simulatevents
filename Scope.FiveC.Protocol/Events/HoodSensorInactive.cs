namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HoodSensorInactive event
	/// </summary>
	public partial class HoodSensorInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HoodSensorInactive; }
		}
	}
}
