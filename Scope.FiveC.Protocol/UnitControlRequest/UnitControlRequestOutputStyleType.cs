using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// Control the behaviour of the output when the port it turned on.
	/// </summary>
	[Serializable]
	public enum UnitControlRequestOutputStyleType
	{
		/// <summary>
		/// Normal operation where the port is switched on or off depending on the state.
		/// </summary>
		Normal,

		/// <summary>
		/// The port switches on for a period, then switches off and stays off.
		/// </summary>
		/// <remarks>
		/// The period is configurable, the parameter is the 'One Shot Timeout' parameter.
		/// </remarks>
		Item1Shot,

		/// <summary>
		/// The port oscillates at 0.5 Hz, 50% duty cycle.
		/// </summary>
		HalfHzFixedFreq,

		/// <summary>
		/// The port oscillates at 1 Hz, 50% duty cycle.
		/// </summary>
		Item1HzFixedFreq,

		/// <summary>
		/// The port oscillates at 2.5 Hz, 50% duty cycle.
		/// </summary>
		Item2HalfHzFixedFreq,

		/// <summary>
		/// The port oscillates at 5 Hz, 50% duty cycle.
		/// </summary>
		Item5HzFixedFreq,

		/// <summary>
		/// The port starts a progressive state change with parameter 1.
		/// </summary>
		/// <remarks>
		/// The unit will pulse the output with progressively longer pulses, until the output remains on.
		/// </remarks>
		Progressive1,

		/// <summary>
		/// The port starts a progressive state change with parameter 2.
		/// </summary>
		/// <remarks>
		/// The unit will pulse the output with progressively longer pulses, until the output remains on.
		/// </remarks>
		Progressive2,

		/// <summary>
		/// The port is pulsed with a 100ms pulse every second.
		/// </summary>
		Item1PulsePerSec,

		/// <summary>
		/// The port is pulsed with two 100ms pulses every second.
		/// </summary>
		Item2PulsesPerSec,

		/// <summary>
		/// The port is pulsed with three 100ms pulses every second.
		/// </summary>
		Item3PulsesPerSec,

		/// <summary>
		/// The port is switched on for one second, then off.
		/// </summary>
		Item1of1Sec1Shot,

		/// <summary>
		/// The port is switched on for one second, off for one second, on for one second, then off.
		/// </summary>
		Item2of1Sec1Shot,
	}
}
