using System;
using Scope.FiveC.Protocol.Events.Enums;

using System.IO;

namespace Scope.FiveC.Protocol.Events
{
	[Serializable]
	public abstract class ProtocolBufferEventBase : IProtocolBufferEvent
	{
		private const byte CELLOCATOR_SOURCE = 0x08;

		protected ProtocolBufferEventBase()
		{
			this.Header = new EventHeader();
		}

		public abstract EventHeader Header { get; set; }

		/// <summary>
		/// Gets the publicly visible protocol buffer template.
		/// </summary>
		public abstract ProtocolBufferTemplate Template { get; }

		public byte MessageId
		{
			get { return (byte) Template; }
		}

		public int TemplateId
		{
			get { return (int) Template; }
		}


		public void Validate()
		{
			Header.Validate();
			ValidateSpecificFields();
		}

		protected virtual void ValidateSpecificFields()
		{
		}


		#region Wrapped properties

		/// <summary>
		/// Gets or sets the unit identifier.
		/// </summary>
		public string UnitId
		{
			get { return Header.UnitIdSpecified ? Header.UnitId : null; }
			set
			{
				if (value == null)
					Header.UnitIdSpecified = false;
				else
					Header.UnitId = value;
			}
		}

		/// <summary>
		/// Gets or sets the UTC timestamp.
		/// </summary>
		public DateTime? UtcTimestamp
		{
			get { return Header.UtcTimestamp; }
			set { Header.UtcTimestamp = value; }
		}


		/// <summary>
		/// Gets or sets the Latitude.
		/// </summary>
		public decimal? Latitude
		{
			get { return Header.LatitudeSpecified ? (decimal?) Header.Latitude : null; }
			set
			{
				if (value == null)
					Header.LatitudeSpecified = false;
				else
					Header.Latitude = (double) value.Value;
			}
		}

		/// <summary>
		/// Gets or sets the Longitude.
		/// </summary>
		public decimal? Longitude
		{
			get { return Header.LongitudeSpecified ? (decimal?) Header.Longitude : null; }
			set
			{
				if (value == null)
					Header.LongitudeSpecified = false;
				else
					Header.Longitude = (double) value.Value;
			}
		}

		public byte Source
		{
			get { return Header.SourceSpecified ? (byte) Header.Source : CELLOCATOR_SOURCE; }
			set { Header.Source = value; }
		}


		public string Description
		{
			get { return Header.DescriptionSpecified ? Header.Description : null; }
			set
			{
				if (value == null)
					Header.DescriptionSpecified = false;
				else
					Header.Description = value;
			}
		}

		public InputStatusType? InputStatus
		{
			get { return Header.InputStatusSpecified ? (InputStatusType?)Header.InputStatus : null; }
			set
			{
				if (value == null)
					Header.InputStatusSpecified = false;
				else
					Header.InputStatus = (uint)value.Value;
			}
		}

		public OutputStatusType? OutputStatus
		{
			get { return Header.OutputStatusSpecified ? (OutputStatusType?)Header.OutputStatus : null; }
			set
			{
				if (value == null)
					Header.OutputStatusSpecified = false;
				else
					Header.OutputStatus = (uint)value.Value;
			}
		}

		public uint? Odometer
		{
			get { return Header.OdometerSpecified ? (uint?) Header.Odometer : null; }
			set
			{
				if (value == null)
					Header.OdometerSpecified = false;
				else
					Header.Odometer = value.Value;
			}
		}

		public uint? DriverKeyCode
		{
			get { return Header.DriverKeyCodeSpecified ? (uint?) Header.DriverKeyCode : null; }
			set
			{
				if (value == null)
					Header.DriverKeyCodeSpecified = false;
				else
					Header.DriverKeyCode = value.Value;
			}
		}

		/*public string SourceAddress
		{
			get { return Header.SourceAddressSpecified ? Header.SourceAddress : null; }
			set
			{
				if (value == null)
					Header.SourceAddressSpecified = false;
				else
					Header.SourceAddress = value;
			}
		}

		public string Registration
		{
			get { return Header.RegistrationSpecified ? Header.Registration : null; }
			set
			{
				if (value == null)
					Header.RegistrationSpecified = false;
				else
					Header.Registration = value;
			}
		}*/

		public ushort? Speed
		{
			get { return Header.SpeedSpecified ? (ushort?) Header.Speed : null; }
			set
			{
				if (value == null)
					Header.SpeedSpecified = false;
				else
					Header.Speed = value.Value;
			}
		}

		public ushort? Direction
		{
			get { return Header.DirectionSpecified ? (ushort?) Header.Direction : null; }
			set
			{
				if (value == null)
					Header.DirectionSpecified = false;
				else
					Header.Direction = value.Value;
			}
		}


		public GeneralStatusType? GeneralStatus
		{
			get
			{
				return Header.GeneralStatusSpecified ? (GeneralStatusType?)Header.GeneralStatus : null;
			}
			set
			{
				Header.GeneralStatus = (value != null) ? (uint)value.Value : default(uint);
				Header.GeneralStatusSpecified = (value != null);
			}
		}

		public TripSpeedSource? TripSpeedSource
		{
			get
			{
				return Header.TripSpeedSourceSpecified ? (TripSpeedSource?)Header.TripSpeedSource : null;
			}
			set
			{
				Header.TripSpeedSource = (value != null) ? value.Value : default(uint);
				Header.TripSpeedSourceSpecified = (value != null);
			}
		}



		#endregion


		public void Serialize(Stream stream)
		{
			if (!stream.CanWrite)
				throw new ArgumentException("Stream must support write.", "stream");
			ProtoBuf.Serializer.Serialize(stream, this);
		}
	}
}
