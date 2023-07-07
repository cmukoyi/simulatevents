

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 6 off event
	/// </summary>
	public partial class Input6Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input6Off; }
		}
	}
}
