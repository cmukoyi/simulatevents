using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// A request to disable the unit.
	/// </summary>
	[Serializable]
	[ProtoContract]
	public class UnitControlRequestDisable
	{
		#region Public Members

		/// <summary>
		/// On (disabled) or off.
		/// </summary>
		[ProtoMember(1)]
		public UnitControlRequestStateType State
		{
			get { return _State; }
			set { _State = value; }
		}

		#endregion

		#region Private Members

		private UnitControlRequestStateType _State;

		#endregion
	}
}
