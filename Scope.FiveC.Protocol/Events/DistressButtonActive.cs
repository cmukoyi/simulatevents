

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Distress button active event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 70</remarks>
	public partial class DistressButtonActive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DistressButtonActive; }
		}
	}
}
