

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 1 on event
	/// </summary>
	public partial class Input1On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input1On; }
		}
	}
}
