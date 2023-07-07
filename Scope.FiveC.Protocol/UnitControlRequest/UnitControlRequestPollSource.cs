using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// The source to acquire the position from when polling.
	/// </summary>
	[Serializable]
	public enum UnitControlRequestPollSource
	{
		/// <summary>
		/// Determine the position from the Global Positioning Satellite receiver.
		/// </summary>
		Gps,

		/// <summary>
		/// Determine the position from operational parameters of the GSM radio.
		/// </summary>
		[Obsolete("Use of GSM polling has been deprecated in favour of GPS polling.")]
		Gsm,
	}
}
