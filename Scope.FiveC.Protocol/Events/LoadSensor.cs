

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// LoadSensor event
	/// </summary>
	public partial class LoadSensor : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.LoadSensor; }
		}
	}
}
