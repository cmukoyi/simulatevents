

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Input 7 off event
	/// </summary>
	public partial class Input7Off : InputOnOffEventBase, IInputOnOffEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Input7Off; }
		}
	}
}
