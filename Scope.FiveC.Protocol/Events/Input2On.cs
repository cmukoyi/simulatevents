

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 2 on event
	/// </summary>
	public partial class Input2On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input2On; }
		}
	}
}
