

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Non-trip Position event
	/// </summary>
	public partial class NonTripPosition : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.NonTripPosition; }
		}
	}
}
