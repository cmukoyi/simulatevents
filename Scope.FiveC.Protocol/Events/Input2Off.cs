

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 2 off event
	/// </summary>
	public partial class Input2Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input2Off; }
		}
	}
}
