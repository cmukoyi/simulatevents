

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Temperature3Normal event
	/// </summary>
	public partial class Temperature3Normal : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Temperature3Normal; }
		}
	}
}
