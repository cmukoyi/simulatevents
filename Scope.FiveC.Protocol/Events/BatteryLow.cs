using System;


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Battery low event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 83</remarks>
	public partial class BatteryLow : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BatteryLow; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			if (this.TemperatureSpecified && (this.Temperature < -55 || this.Temperature > 200))
				throw new ProtocolBufferValidationException("Temperature", "Must be between -55 and 200");
		}
	}
}
