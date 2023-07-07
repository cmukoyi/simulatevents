

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// FMSData event
	/// </summary>
	public partial class FMSData : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.FMSData; }
		}
	}
}
