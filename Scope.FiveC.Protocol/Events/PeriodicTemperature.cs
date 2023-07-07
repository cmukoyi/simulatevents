

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Periodic temperature event
	/// </summary>
	public partial class PeriodicTemperature : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.PeriodicTemperature; }
		}
	}
}
