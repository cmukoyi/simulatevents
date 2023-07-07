namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysis5sEvent event
	/// </summary>
	public partial class AccidentAnalysis5sEvent : AccidentAnalysisEventBase, IAccidentAnalysisEvent
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysis5sEvent; }
		}
	}
}
