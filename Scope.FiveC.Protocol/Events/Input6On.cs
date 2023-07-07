

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 6 on event
	/// </summary>
	public partial class Input6On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input6On; }
		}
	}
}
