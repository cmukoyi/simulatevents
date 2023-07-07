

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// GeoHotSpotExit event
	/// </summary>
	public partial class GeoHotSpotExit : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GeoHotSpotExit; }
		}


		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();

			if (ReferenceIdSpecified && (ReferenceId > 65535))
				throw new ProtocolBufferValidationException("ReferenceId", "Must be between 0 and 65535");
		}
	}
}
