

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// TripShutdown event
	/// </summary>
	public partial class TripShutdown : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.TripShutdown; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			if (this.GreenTimePercentSpecified && this.GreenTimePercent > 100)
				throw new ProtocolBufferValidationException("GreenTimePercent", "Must be between 0 and 100");
		}
	}
}
