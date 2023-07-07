


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// CustomEvent1 event
	/// </summary>
	public partial class CustomEvent1 : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.CustomEvent1; }
		}
	}
}
