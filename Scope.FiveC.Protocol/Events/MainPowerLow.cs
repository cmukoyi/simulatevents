namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Main power low event
	/// </summary>
	public partial class MainPowerLow : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.MainPowerLow; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();

			if (ThresholdVoltsSpecified && ThresholdVolts > 25.5)
				throw new ProtocolBufferValidationException("Threshold", "Must be between 0 and 25.5");
			
			if (ValueVoltsSpecified && ValueVolts > 25.5)
				throw new ProtocolBufferValidationException("Value", "Must be between 0 and 25.5");
		}
	}
}
