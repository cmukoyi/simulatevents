

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Driver authentication event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 46</remarks>
	public partial class DriverAuthentication : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DriverAuthentication; }
		}
	}
}
