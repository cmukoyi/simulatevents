using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// The state type used in the UnitControlRequest/1.0 schema.
	/// </summary>
	[Serializable]
	public enum UnitControlRequestStateType
	{
		/// <summary>
		/// On
		/// </summary>
		On,

		/// <summary>
		/// Off
		/// </summary>
		Off,
	}
}
