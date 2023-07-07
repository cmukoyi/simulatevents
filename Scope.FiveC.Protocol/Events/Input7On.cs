

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 7 on event
	/// </summary>
	public partial class Input7On : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input7On; }
		}
	}
}
