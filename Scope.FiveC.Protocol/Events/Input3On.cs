

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 3 on event
	/// </summary>
	public partial class Input3On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input3On; }
		}
	}
}
