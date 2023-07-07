

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// FacilityStatus event
	/// </summary>
	public partial class FacilityStatus : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.FacilityStatus; }
		}
	}
}
