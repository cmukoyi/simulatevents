using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// Used to poll a unit for a position.
	/// </summary>
	[Serializable]
	[ProtoContract]
	public class UnitControlRequestPoll
	{
		#region Public Members

		/// <summary>
		/// The method of acquiring the position - either GPS or GSM.
		/// </summary>
		[ProtoMember(1)]
		public UnitControlRequestPollSource Type
		{
			get { return _Type; }
			set { _Type = value; }
		}

		#endregion

		#region Private Members

		private UnitControlRequestPollSource _Type;

		#endregion
	}
}
