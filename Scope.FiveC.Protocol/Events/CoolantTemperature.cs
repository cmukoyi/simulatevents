


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// CoolantTemperature event
	/// </summary>
	public partial class CoolantTemperature : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.CoolantTemperature; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();

			if (this.MilStatusSpecified && this.MilStatus > 255)
				throw new ProtocolBufferValidationException("MilStatus", "Must be between 0 and 255");

			if (this.RpmSpecified && this.Rpm > 25500)
				throw new ProtocolBufferValidationException("Rpm", "Must be between 0 and 25500");

			if (this.ThrottlePositionSpecified && this.ThrottlePosition > 255)
				throw new ProtocolBufferValidationException("ThrottlePosition", "Must be between 0 and 255");

			if (this.EngineLoadValueSpecified && this.EngineLoadValue > 255)
				throw new ProtocolBufferValidationException("EngineLoadValue", "Must be between 0 and 255");

			if (this.EngineLoadLimitSpecified && this.EngineLoadLimit > 100)
				throw new ProtocolBufferValidationException("EngineLoadLimit", "Must be between 0 and 100");

			if (this.EngineLoadTimeLimitSpecified && this.EngineLoadTimeLimit > 65535)
				throw new ProtocolBufferValidationException("EngineLoadTimeLimit", "Must be between 0 and 65535");

			if (this.EngineCoolantTemperatureSpecified && (this.EngineCoolantTemperature < -40 || this.EngineCoolantTemperature > 215))
				throw new ProtocolBufferValidationException("EngineCoolantTemperature", "Must be between -40 and 215");

			if (this.EngineCoolantTemperatureLimitSpecified && this.EngineCoolantTemperatureLimit > 255)
				throw new ProtocolBufferValidationException("EngineCoolantTemperatureLimit", "Must be between 0 and 255");

			if (this.FuelLevelValueSpecified && this.FuelLevelValue > 100)
				throw new ProtocolBufferValidationException("FuelLevelValue", "Must be between 0 and 100");

			if (this.FuelLevelLowLimitSpecified && this.FuelLevelLowLimit > 100)
				throw new ProtocolBufferValidationException("FuelLevelLowLimit", "Must be between 0 and 100");

			if (this.InstantaneousFuelEconomySpecified && this.InstantaneousFuelEconomy > 100)
				throw new ProtocolBufferValidationException("InstantaneousFuelEconomy", "Must be between 0 and 255");
		}
	}
}
