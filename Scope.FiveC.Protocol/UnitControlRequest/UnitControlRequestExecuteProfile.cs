using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// Request that a specific profile number is activated on the unit.
	/// </summary>
	[Serializable]
	[ProtoContract]
	public class UnitControlRequestExecuteProfile
	{
		#region Public Members

		/// <summary>
		/// The profile number to activate.
		/// </summary>
		[ProtoMember(1)]
		public string ProfileNo
		{
			get { return _Profileno; }
			set { _Profileno = value; }
		}

		#endregion

		#region Private Members

		private string _Profileno;

		#endregion
	}
}
