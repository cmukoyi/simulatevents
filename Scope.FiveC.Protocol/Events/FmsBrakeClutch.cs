

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// FmsBrakeClutch event
	/// </summary>
	public partial class FmsBrakeClutch : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.FmsBrakeClutch; }
		}
	}
}
