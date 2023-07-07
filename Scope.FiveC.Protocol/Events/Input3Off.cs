

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 3 off event
	/// </summary>
	public partial class Input3Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input3Off; }
		}
	}
}
