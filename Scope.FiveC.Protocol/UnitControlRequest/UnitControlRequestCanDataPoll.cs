using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// Request CAN bus related data to be sent.
	/// </summary>
	[Serializable]
	[ProtoContract]
	public class UnitControlRequestCanDataPoll
	{ }
}
