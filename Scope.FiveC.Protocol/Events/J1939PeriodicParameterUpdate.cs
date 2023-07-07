


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939PeriodicParameterUpdate event
	/// </summary>
	public partial class J1939PeriodicParameterUpdate : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939PeriodicParameterUpdate; }
		}
	}
}
