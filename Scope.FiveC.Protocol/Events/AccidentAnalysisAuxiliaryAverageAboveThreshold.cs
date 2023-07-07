namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysisAuxiliaryAverageAboveThreshold event
	/// </summary>
	public partial class AccidentAnalysisAuxiliaryAverageAboveThreshold : AccidentAnalysisEventBase, IAccidentAnalysisEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysisAuxiliaryAverageAboveThreshold; }
		}
	}
}
