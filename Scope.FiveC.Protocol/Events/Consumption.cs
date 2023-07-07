

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Consumption event
	/// </summary>
	public partial class Consumption : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.Consumption; }
		}
	}
}
