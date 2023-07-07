

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ExternalAlarmInactive event
	/// </summary>
	public partial class ExternalAlarmInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExternalAlarmInactive; }
		}
	}
}
