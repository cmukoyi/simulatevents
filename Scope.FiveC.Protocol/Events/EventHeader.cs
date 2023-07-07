using System;
using Scope.FiveC.Protocol.Extensions;

namespace Scope.FiveC.Protocol.Events
{
	public partial class EventHeader
	{
		/// <summary>
		/// Gets or sets the UTC timestamp.
		/// </summary>
		public DateTime? UtcTimestamp
		{
			get
			{
				return UtcTimestampSecondsSpecified
					? UnixDateTimeExtensions.FromUnixSecondsUtc(UtcTimestampSeconds)
					: null;
			}
			set
			{
				var unixSeconds = value.ToUnixSecondsUtc();
				if (unixSeconds == null)
					UtcTimestampSecondsSpecified = false;
				else
					UtcTimestampSeconds = unixSeconds.Value;
			}
		}

		public void Validate()
		{
			/*if (this.GpsStatusSpecified && this.GpsStatus > byte.MaxValue)
				throw new ProtocolBufferValidationException("GpsStatus", "Exceeds " + byte.MaxValue);
			if (this.AntennaStatusSpecified && this.AntennaStatus > byte.MaxValue)
				throw new ProtocolBufferValidationException("AntennaStatus", "Exceeds " + byte.MaxValue);*/
			if (this.InputStatusSpecified && this.InputStatus > ushort.MaxValue)
				throw new ProtocolBufferValidationException("InputStatus", "Exceeds " + ushort.MaxValue);
			if (this.OutputStatusSpecified && this.OutputStatus > ushort.MaxValue)
				throw new ProtocolBufferValidationException("OutputStatus", "Exceeds " + ushort.MaxValue);
			if (this.SpeedSpecified && this.Speed > ushort.MaxValue)
				throw new ProtocolBufferValidationException("Speed", "Exceeds " + ushort.MaxValue);
			if (this.DirectionSpecified && this.Direction > ushort.MaxValue)
				throw new ProtocolBufferValidationException("Direction", "Exceeds " + ushort.MaxValue);

			ValidateSpecificFields();
		}

		public virtual void ValidateSpecificFields()
		{
		}
	}
}
