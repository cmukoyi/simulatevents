


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// FuelData event
	/// </summary>
	public partial class FuelData : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.FuelData; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			if (ReasonSpecified && Reason > 255)
				throw new ProtocolBufferValidationException("Reason", "Must be between 0 and 255");

			if (FuelLevelPercentsSpecified && FuelLevelPercents > 100)
				throw new ProtocolBufferValidationException("FuelLevelPercents", "Must be between 0 and 100");

			if (TotalFuelLitersSpecified && TotalFuelLiters > 65535)
				throw new ProtocolBufferValidationException("TotalFuelLiters", "Must be between 0 and 65535");
			
		}
	}
}
