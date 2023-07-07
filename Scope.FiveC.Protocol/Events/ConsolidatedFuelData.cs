

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ConsolidatedFuelData event
	/// </summary>
	public partial class ConsolidatedFuelData : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ConsolidatedFuelData; }
		}
	}
}
