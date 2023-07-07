

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// RFIDInformation event
	/// </summary>
	public partial class RFIDInformation : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.RFIDInformation; }
		}
	}
}
