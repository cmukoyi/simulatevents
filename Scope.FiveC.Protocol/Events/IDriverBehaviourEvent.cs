using Scope.FiveC.Protocol.Events.Enums;


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// An interface for all Driver Behaviour events
	/// </summary>
	public interface IDriverBehaviourEvent
	{
		double StartLatitude { get; set; }
		bool StartLatitudeSpecified { get; set; }
		double StartLongitude { get; set; }
		bool StartLongitudeSpecified { get; set; }
		uint StartGpsStatus { get; set; }
		bool StartGpsStatusSpecified { get; set; }
		uint StartSpeed { get; set; }
		bool StartSpeedSpecified { get; set; }
		float DurationSeconds { get; set; }
		bool DurationSecondsSpecified { get; set; }
		uint DistanceMeters { get; set; }
		bool DistanceMetersSpecified { get; set; }
		float AccelerometerX { get; set; }
		bool AccelerometerXSpecified { get; set; }
		float AccelerometerY { get; set; }
		bool AccelerometerYSpecified { get; set; }
		float AccelerometerZ { get; set; }
		bool AccelerometerZSpecified { get; set; }
		uint ForceDirection { get; set; }
		bool ForceDirectionSpecified { get; set; }
		uint MaximumRpm { get; set; }
		bool MaximumRpmSpecified { get; set; }
		uint MaximumSpeed { get; set; }
		bool MaximumSpeedSpecified { get; set; }
		float ThrottlePositionPercent { get; set; }
		bool ThrottlePositionPercentSpecified { get; set; }
		uint OdbFlags { get; set; }
		bool OdbFlagsSpecified { get; set; }
		uint RoadSurfaceType { get; set; }
		bool RoadSurfaceTypeSpecified { get; set; }
	}
}
