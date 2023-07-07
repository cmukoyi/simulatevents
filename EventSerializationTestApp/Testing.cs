using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Common;
using Common.Extensions;
using Scope.FiveC.Protocol;
using Scope.FiveC.Protocol.Events;
using Scope.FiveC.Protocol.Events.Enums;

namespace EventSerializationTestApp
{
	/// <summary>
	/// This is a class for testing purpose
	/// </summary>
	public class Testing
	{
		/// <summary>
		/// Show serialized data in a textbox
		/// </summary>
		public static void ShowSerializedDataInTextbox(TextBox textBox)
		{
			byte[] data = SerializeTesteEvent();
			textBox.Text = string.Format(CultureInfo.InvariantCulture,
				"=== TEST ==={0}Hex: {1}{0}Base64: {2}",
				Environment.NewLine, Utils.AsHexString(data), Convert.ToBase64String(data));
		}


		/// <summary>
		/// Serialize a test event to binary data
		/// </summary>
		/// <returns></returns>
		private static byte[] SerializeTesteEvent()
		{
			const ProtocolBufferTemplate template = ProtocolBufferTemplate.PeriodicPosition;
			const string unitId = "test_unit";
			DateTime eventDateTime = DateTime.UtcNow;

			EventHeader header = GetEventHeader(template, unitId, eventDateTime);
			header.Direction = 95;
			header.DriverKeyCode = 0;
			header.GeneralStatus = 0;
			header.InputStatus = 34;
			header.Latitude = -25.313069599999999;
			header.Longitude = -57.5806963;
			header.Odometer = 0;
			header.OutputStatus = 0;
			header.Source = 0;
			header.Speed = 0;
			header.TripSpeedSource = 0;
			header.UtcTimestampSeconds = 1427128381;

			var ev = new PeriodicPosition { Header = header };
			ev.Rpm = 0;
			ev.TripDistanceMeters = 0;
			ev.TripDurationSeconds = 0;

			// serialize event
			byte[] eventData;
			using (var ms = new MemoryStream())
			{
				ProtoBuf.Serializer.Serialize(ms, ev);
				eventData = ms.ToArray();
			}

			return eventData;
		}


		/// <summary>
		/// Get event header which is common for all the events
		/// </summary>
		/// <param name="template"></param>
		/// <param name="unitId"></param>
		/// <param name="eventDateTime">This DateTime will be converted to UTC seconds</param>
		/// <returns></returns>
		private static EventHeader GetEventHeader(ProtocolBufferTemplate template, string unitId, DateTime eventDateTime)
		{
			var eh = new EventHeader();

			// a number identifying the template
			eh.TemplateId = (uint)template;
			// unit identifier
			eh.UnitId = unitId;
			// event description
			eh.Description = template.ToString();
			// seconds since 1970-01-01 00:00:00 UTC
			eh.UtcTimestampSeconds = eventDateTime.ToUnixSeconds();
			// Position Latitude in degrees
			eh.Latitude = 28.011830;
			// Position Longitude in degrees
			eh.Longitude = -15.533625;
			// Speed km/h
			eh.Speed = 0;
			// Degrees 0..360
			eh.Direction = 0;
			// Odometer in km
			eh.Odometer = 0;
			// InputStatus - first input on others off
			eh.InputStatus = 0x01;
			// OutputStatus - first output on, others off
			eh.OutputStatus = 0x01;
			// GeneralStatus
			eh.GeneralStatus = (uint)GeneralStatusType.GENERAL_STATUS_INPUT_OUTPUT_INFORMATION_AVAILABLE + (uint)GeneralStatusType.GENERAL_STATUS_GPS_STATUS_VALID;

			return eh;
		}

	}
}
