


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939ThresholdReset event
	/// </summary>
	public partial class J1939ThresholdReset : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939ThresholdReset; }
		}
	}
}
