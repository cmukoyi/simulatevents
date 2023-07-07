using Scope.FiveC.Protocol.Events.Enums;


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// An interface for all Accident Analysis events
	/// </summary>
	public interface IAccidentAnalysisEvent
	{
		uint EventDurationMillisceonds { get; set; }
		bool EventDurationMillisceondsSpecified { get; set; }
		uint StartSpeedKmh { get; set; }
		bool StartSpeedKmhSpecified { get; set; }
		double AccidentLatitude { get; set; }
		bool AccidentLatitudeSpecified { get; set; }
		double AccidentLongitude { get; set; }
		bool AccidentLongitudeSpecified { get; set; }
		float MaxAccelerationR { get; set; }
		bool MaxAccelerationRSpecified { get; set; }
		float AverageAccelerationR { get; set; }
		bool AverageAccelerationRSpecified { get; set; }
		float AverageAccelerationX { get; set; }
		bool AverageAccelerationXSpecified { get; set; }
		float AverageAccelerationY { get; set; }
		bool AverageAccelerationYSpecified { get; set; }
		float AverageAccelerationZ { get; set; }
		bool AverageAccelerationZSpecified { get; set; }
		uint MaxRpm { get; set; }
		bool MaxRpmSpecified { get; set; }
		float MaxThrottlePercentage { get; set; }
		bool MaxThrottlePercentageSpecified { get; set; }
		uint TimestampMilliseconds { get; set; }
		bool TimestampMillisecondsSpecified { get; set; }
		float StartDirectionDegrees { get; set; }
		bool StartDirectionDegreesSpecified { get; set; }
		float ImpactDirectionDegrees { get; set; }
		bool ImpactDirectionDegreesSpecified { get; set; }
	}
}
