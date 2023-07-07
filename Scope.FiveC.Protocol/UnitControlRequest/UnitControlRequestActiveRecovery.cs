using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// Request that the unit enters Active Recovery mode.
	/// </summary>
	[Serializable]
	[ProtoContract]
	public class UnitControlRequestActiveRecovery
	{
		#region Public Members

		/// <summary>
		/// The state to enter.
		/// </summary>
		[ProtoMember(1)]
		public UnitControlRequestStateType State
		{
			get { return _State; }
			set { _State = value; }
		}

		/// <summary>
		/// The duration in seconds to remain in the state.
		/// </summary>
		public ushort Duration
		{
			get { return _Duration; }
			set { _Duration = value; }
		}

		#endregion

		#region Private Members

		private ushort _Duration;
		private UnitControlRequestStateType _State;

		#endregion
	}
}
