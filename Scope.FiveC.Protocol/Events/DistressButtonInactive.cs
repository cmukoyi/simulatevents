

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Distress button inactive event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 54</remarks>
	public partial class DistressButtonInactive : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DistressButtonInactive; }
		}
	}
}
