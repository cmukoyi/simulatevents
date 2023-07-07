

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ExternalAlarmActive event
	/// </summary>
	public partial class ExternalAlarmActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExternalAlarmActive; }
		}
	}
}
