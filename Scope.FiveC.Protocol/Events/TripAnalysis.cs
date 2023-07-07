

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// TripAnalysis event
	/// </summary>
	public partial class TripAnalysis : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.TripAnalysis; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			if (RpmBand1Specified && RpmBand1 > 100)
				throw new ProtocolBufferValidationException("RpmBand1", "Must be between 0 and 100");
			if (RpmBand2Specified && RpmBand2 > 100)
				throw new ProtocolBufferValidationException("RpmBand2", "Must be between 0 and 100");
			if (RpmBand3Specified && RpmBand3 > 100)
				throw new ProtocolBufferValidationException("RpmBand3", "Must be between 0 and 100");
			if (RpmBand4Specified && RpmBand4 > 100)
				throw new ProtocolBufferValidationException("RpmBand4", "Must be between 0 and 100");
			if (RpmBand5Specified && RpmBand5 > 100)
				throw new ProtocolBufferValidationException("RpmBand5", "Must be between 0 and 100");
			if (RpmBand6Specified && RpmBand6 > 100)
				throw new ProtocolBufferValidationException("RpmBand6", "Must be between 0 and 100");
			if (RpmBand7Specified && RpmBand7 > 100)
				throw new ProtocolBufferValidationException("RpmBand7", "Must be between 0 and 100");
			if (RpmBand8Specified && RpmBand8 > 100)
				throw new ProtocolBufferValidationException("RpmBand8", "Must be between 0 and 100");
			if (RpmBand9Specified && RpmBand9 > 100)
				throw new ProtocolBufferValidationException("RpmBand9", "Must be between 0 and 100");
			if (SpeedBand1Specified && SpeedBand1 > 100)
				throw new ProtocolBufferValidationException("SpeedBand1", "Must be between 0 and 100");
			if (SpeedBand2Specified && SpeedBand2 > 100)
				throw new ProtocolBufferValidationException("SpeedBand2", "Must be between 0 and 100");
			if (SpeedBand3Specified && SpeedBand3 > 100)
				throw new ProtocolBufferValidationException("SpeedBand3", "Must be between 0 and 100");
			if (SpeedBand4Specified && SpeedBand4 > 100)
				throw new ProtocolBufferValidationException("SpeedBand4", "Must be between 0 and 100");
			if (SpeedBand5Specified && SpeedBand5 > 100)
				throw new ProtocolBufferValidationException("SpeedBand5", "Must be between 0 and 100");
			if (SpeedBand6Specified && SpeedBand6 > 100)
				throw new ProtocolBufferValidationException("SpeedBand6", "Must be between 0 and 100");
			if (SpeedBand7Specified && SpeedBand7 > 100)
				throw new ProtocolBufferValidationException("SpeedBand7", "Must be between 0 and 100");
			if (SpeedBand8Specified && SpeedBand8 > 100)
				throw new ProtocolBufferValidationException("SpeedBand8", "Must be between 0 and 100");
			if (SpeedBand9Specified && SpeedBand9 > 100)
				throw new ProtocolBufferValidationException("SpeedBand9", "Must be between 0 and 100");
			if (DrivingTimeSpecified && DrivingTime > 100)
				throw new ProtocolBufferValidationException("DrivingTime", "Must be between 0 and 100");
			if (IdleTimeSpecified && IdleTime > 100)
				throw new ProtocolBufferValidationException("IdleTime", "Must be between 0 and 100");
			if (PtoTimeSpecified && PtoTime > 100)
				throw new ProtocolBufferValidationException("PtoTime", "Must be between 0 and 100");
			if (DrivingFuelSpecified && DrivingFuel > 65535)
				throw new ProtocolBufferValidationException("DrivingFuel", "Must be between 0 and 65535");
			if (IdleFuelSpecified && IdleFuel > 65535)
				throw new ProtocolBufferValidationException("IdleFuel", "Must be between 0 and 65535");
			if (PtoFuelSpecified && PtoFuel > 65535)
				throw new ProtocolBufferValidationException("PtoFuel", "Must be between 0 and 65535");
		}
	}
}
