using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// Set an output port on or off using a specific behaviour.
	/// </summary>
	[Serializable]
	[ProtoContract]
	public class UnitControlRequestOutput
	{
		#region Public Members

		/// <summary>
		/// The output port to control.
		/// </summary>
		[ProtoMember(1)]
		public int Port
		{
			get { return (int) _Port; }
			set { _Port = (uint) value; }
		}

		/// <summary>
		/// The behaviour to apply.
		/// </summary>
		[ProtoMember(2)]
		public UnitControlRequestOutputStyleType Style
		{
			get { return _Style; }
			set { _Style = value; }
		}

		/// <summary>
		/// The state to set the port to; either on or off.
		/// </summary>
		[ProtoMember(3)]
		public UnitControlRequestStateType State
		{
			get { return _State; }
			set { _State = value; }
		}

		#endregion

		#region Private Members

		private uint _Port;
		private UnitControlRequestStateType _State;
		private UnitControlRequestOutputStyleType _Style;

		#endregion
	}
}
