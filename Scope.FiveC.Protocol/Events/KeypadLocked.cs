

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// KeypadLocked event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class KeypadLocked : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.KeypadLocked; }
		}
	}
}
