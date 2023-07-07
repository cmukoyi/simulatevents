
using System;

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// BatteryHigh event
	/// </summary>
	public partial class BatteryHigh : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BatteryHigh; }
		}
	}
}
