

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Tachograph data event
	/// </summary>
	public partial class TachographData : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.TachographData; }
		}
	}
}
