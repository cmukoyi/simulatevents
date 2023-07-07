

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Analog1High event
	/// </summary>
	public partial class Analog1High : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Analog1High; }
		}
	}
}
