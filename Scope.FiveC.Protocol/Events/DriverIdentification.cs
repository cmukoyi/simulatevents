

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DriverIdentification event
	/// </summary>
	public partial class DriverIdentification : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverIdentification; }
		}
	}
}
