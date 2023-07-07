

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GeofenceProgrammingComplete event
	/// </summary>
	public partial class GeofenceProgrammingComplete : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GeofenceProgrammingComplete; }
		}
	}
}
