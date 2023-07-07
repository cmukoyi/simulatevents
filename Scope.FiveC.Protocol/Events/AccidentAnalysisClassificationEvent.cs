

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AccidentAnalysisClassificationEvent event
	/// </summary>
	public partial class AccidentAnalysisClassificationEvent : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AccidentAnalysisClassificationEvent; }
		}
	}
}
