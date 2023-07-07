

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GeoHotSpotEntry event
	/// </summary>
	public partial class GeoHotSpotEntry : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GeoHotSpotEntry; }
		}


		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();

			if (ReferenceIdSpecified && (ReferenceId > 65535))
				throw new ProtocolBufferValidationException("ReferenceId", "Must be between 0 and 65535");
		}
	}
}
