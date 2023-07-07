

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 1 off event
	/// </summary>
	public partial class Input1Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input1Off; }
		}
	}
}
