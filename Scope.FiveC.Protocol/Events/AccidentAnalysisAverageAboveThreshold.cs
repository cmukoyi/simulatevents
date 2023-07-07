namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysisAverageAboveThreshold event
	/// </summary>
	public partial class AccidentAnalysisAverageAboveThreshold : AccidentAnalysisEventBase, IAccidentAnalysisEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysisAverageAboveThreshold; }
		}
	}
}
