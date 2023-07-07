namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HotwireSensorInactive event
	/// </summary>
	public partial class HotwireSensorInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HotwireSensorInactive; }
		}
	}
}
