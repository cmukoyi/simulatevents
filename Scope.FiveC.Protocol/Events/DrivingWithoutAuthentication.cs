


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// DrivingWithoutAuthentication event
	/// </summary>
	public partial class DrivingWithoutAuthentication : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.DrivingWithoutAuthentication; }
		}
	}
}
