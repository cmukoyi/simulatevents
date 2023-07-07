

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// CustomCANData event
	/// </summary>
	public partial class CustomCANData : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.CustomCANData; }
		}
	}
}
