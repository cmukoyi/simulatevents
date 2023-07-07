

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ExcessiveRpm event
	/// </summary>
	public partial class ExcessiveRpm : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ExcessiveRpm; }
		}
	}
}
