

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Recovery event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class Recovery : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Recovery; }
		}
	}
}
