

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// An base class for all Accident Analysis events
	/// </summary>
	public abstract class AccidentAnalysisEventBase : ProtocolBufferEventBase
	{
		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			var accidentEvent = (IAccidentAnalysisEvent) this;
			if (accidentEvent.AccidentLatitudeSpecified &&
			    (accidentEvent.AccidentLatitude < -90.0 || accidentEvent.AccidentLatitude > 90.0))
				throw new ProtocolBufferValidationException("AccidentLatitude", "Must be between -90 and 90",
					accidentEvent.AccidentLatitude);

			if (accidentEvent.AccidentLongitudeSpecified &&
			    (accidentEvent.AccidentLongitude < -180.0 || accidentEvent.AccidentLongitude > 180.0))
				throw new ProtocolBufferValidationException("AccidentLongitude", "Must be between -180 and 180",
					accidentEvent.AccidentLongitude);
		}
	}
}
