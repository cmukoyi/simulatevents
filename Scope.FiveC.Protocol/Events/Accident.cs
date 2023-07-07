


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Accident event
	/// </summary>
	public partial class Accident : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Accident; }
		}

	}
}
