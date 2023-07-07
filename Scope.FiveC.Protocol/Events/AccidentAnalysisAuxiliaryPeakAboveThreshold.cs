namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysisAuxiliaryPeakAboveThreshold event
	/// </summary>
	public partial class AccidentAnalysisAuxiliaryPeakAboveThreshold : AccidentAnalysisEventBase, IAccidentAnalysisEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysisAuxiliaryPeakAboveThreshold; }
		}
	}
}
