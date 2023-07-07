

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// An interface for all input on/off
	/// </summary>
	public interface IInputOnOffEvent
	{
		uint DurationSeconds { get; set; }
		uint DelaySeconds { get; set; }
		bool DurationSecondsSpecified { get; set; }
		bool DelaySecondsSpecified { get; set; }
	}
}
