


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// ConfigurationChanged event
	/// </summary>
	public partial class ConfigurationChanged : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.ConfigurationChanged; }
		}
	}
}
