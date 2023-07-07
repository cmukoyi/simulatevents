


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// J1939ThresholdBreach event
	/// </summary>
	public partial class J1939ThresholdBreach : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.J1939ThresholdBreach; }
		}
	}
}
