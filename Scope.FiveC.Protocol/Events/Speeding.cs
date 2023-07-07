


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Speeding event
	/// </summary>
	public partial class Speeding : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Speeding; }
		}
	}
}
