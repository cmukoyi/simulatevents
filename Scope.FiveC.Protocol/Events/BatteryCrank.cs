

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// BatteryCrank event
	/// </summary>
	public partial class BatteryCrank : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BatteryCrank; }
		}
	}
}
