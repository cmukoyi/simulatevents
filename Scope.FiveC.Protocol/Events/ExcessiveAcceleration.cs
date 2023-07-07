

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Excessive acceleration event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 46</remarks>
	public partial class ExcessiveAcceleration : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExcessiveAcceleration; }
		}
	}
}
