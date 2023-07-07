namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// HotwireSensorActive event
	/// </summary>
	public partial class HotwireSensorActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.HotwireSensorActive; }
		}
	}
}
