
using System;

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// AntiTheftAlarm event
	/// </summary>
	public partial class AntiTheftAlarm : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.AntiTheftAlarm; }
		}
	}
}
