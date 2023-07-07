

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverFatigue event
	/// </summary>
	public partial class DriverFatigue : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverFatigue; }
		}
	}
}
