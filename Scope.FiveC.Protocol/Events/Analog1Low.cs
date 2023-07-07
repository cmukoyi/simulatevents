

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Analog1Low event
	/// </summary>
	public partial class Analog1Low : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Analog1Low; }
		}
	}
}
