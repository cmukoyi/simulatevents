

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// MonthlyOdometer event
	/// </summary>
	public partial class MonthlyOdometer : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.MonthlyOdometer; }
		}
	}
}
