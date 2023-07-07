

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 8 off event
	/// </summary>
	public partial class Input8Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input8Off; }
		}
	}
}
