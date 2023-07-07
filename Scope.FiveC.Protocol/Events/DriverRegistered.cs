

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverRegistered event
	/// </summary>
	public partial class DriverRegistered : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverRegistered; }
		}
	}
}
