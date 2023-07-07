using System;
using Scope.FiveC.Protocol.Events.Enums;


namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// Geofence exit event
	/// </summary>
	/// <remarks>Cellocator Transmission Reason: 254</remarks>
	public partial class GeofenceExit : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.GeofenceExit; }
		}

		protected override void ValidateSpecificFields()
		{
			base.ValidateSpecificFields();
			if (this.ReferenceIdSpecified && this.ReferenceId > 65535)
				throw new ProtocolBufferValidationException("ReferenceId", "Must be between 0 and 65535");
			if (this.GeofenceTypeSpecified && this.GeofenceType > 255)
				throw new ProtocolBufferValidationException("GeofenceType", "Must be between 0 and 255");
		}
	}
}
