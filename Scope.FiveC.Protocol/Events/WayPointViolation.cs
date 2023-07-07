

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// WayPointViolation event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: </remarks>
	public partial class WayPointViolation : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.WayPointViolation; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			if (this.ReferenceIdSpecified && this.ReferenceId > 65535)
				throw new ProtocolBufferValidationException("ReferenceId", "Must be between 0 and 65535");
		}
	}
}
