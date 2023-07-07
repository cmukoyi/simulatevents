namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysis10sEvent event
	/// </summary>
	public partial class AccidentAnalysis10sEvent : AccidentAnalysisEventBase, IAccidentAnalysisEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysis10sEvent; }
		}
	}
}
