using System;
using System.Collections.Generic;
using Common.Extensions;
using Scope.FiveC.Protocol;
using Scope.FiveC.Protocol.Events;
using Scope.FiveC.Protocol.Events.Enums;

namespace EventSending
{
	/// <summary>
	/// Event Factory class for event creation
	/// </summary>
	public class EventFactory
	{
		public static object Create(ProtocolBufferTemplate template, string unitId, DateTime eventDateTime, IDictionary<string, object> eventParameters = null)
		{
			EventHeader header = GetEventHeader(template, unitId, eventDateTime);
			object value;

			switch (template)
			{
				case ProtocolBufferTemplate.NonTripPosition:
				{
					var ev = new NonTripPosition {Header = header};
					
					// set additional parameters
					if (eventParameters != null)
					{
						if (eventParameters.TryGetValue("SmsCount", out value))
							ev.SmsCount = (uint)value;
					}

					return ev;
				}

				default:
					throw new NotImplementedException("Event creation not implemented for this template: " + template);
			}
		}


		/// <summary>
		/// Get event header which is common for all the events
		/// </summary>
		/// <param name="template"></param>
		/// <param name="unitId"></param>
		/// <param name="eventDateTime">This DateTime will be converted to UTC seconds</param>
		/// <returns></returns>
		public static EventHeader GetEventHeader(ProtocolBufferTemplate template, string unitId, DateTime eventDateTime)
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
			eh.Latitude = -26.026640;
			// Position Longitude in degrees
			eh.Longitude = 28.004780;
			// Speed km/h
			eh.Speed = 100;
			// Degrees 0..360
			eh.Direction = 0;
			// Odometer in km
			eh.Odometer = 2000;
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
