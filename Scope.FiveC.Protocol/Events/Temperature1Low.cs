

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature1Low event
	/// </summary>
	public partial class Temperature1Low : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature1Low; }
		}
	}
}
