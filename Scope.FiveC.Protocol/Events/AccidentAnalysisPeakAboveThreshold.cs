namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysisPeakAboveThreshold event
	/// </summary>
	public partial class AccidentAnalysisPeakAboveThreshold : AccidentAnalysisEventBase, IAccidentAnalysisEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysisPeakAboveThreshold; }
		}
	}
}
