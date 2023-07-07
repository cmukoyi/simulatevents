using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Common;
using EventSending.Properties;
using NLog;
using Scope.FiveC.Protocol;
using Scope.FiveC.Protocol.Events;
using ThirdPartyGatewayApi.Api;
using ThirdPartyGatewayApi.Entities;

namespace EventSending
{
	/// <summary>
	/// Main application class for event sending
	/// </summary>
	public class Application
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		private readonly Settings _settings;
		private readonly string[] _args;


		public Application(Settings settings, string[] args)
		{
			_settings = settings;
			_args = args;
		}


		/// <summary>
		/// The main function which will be executed when program starts
		/// </summary>
		public void Run()
		{
			Logger.Trace(CultureInfo.InvariantCulture, "Run()");

            // Create a NonTripPosition event
            //NonTripPosition ev = (NonTripPosition)EventFactory.Create(ProtocolBufferTemplate.NonTripPosition, _settings.UnitId, DateTime.UtcNow);

            // Create a MILStatus event
            //  MILStatus ev = new MILStatus { Header = EventFactory.GetEventHeader(ProtocolBufferTemplate.MILStatus, _settings.UnitId, DateTime.UtcNow) };

            //  ev.DtcCount = 2;
            //   ev.Dtc1 = 0x0101;
            //	ev.Dtc2 = 0x0202;

            // Create trip startup
            // TripStartup ev = new TripStartup { Header = EventFactory.GetEventHeader(ProtocolBufferTemplate.TripStartup, _settings.UnitId, DateTime.UtcNow) };


            //  ev.TripId = 12;
            //  ev.TripStartDelaySeconds= 0;

            //periodic
            // PeriodicPosition ev = new PeriodicPosition { Header = EventFactory.GetEventHeader(ProtocolBufferTemplate.PeriodicPosition, _settings.UnitId, DateTime.UtcNow) };
            //ev.Rpm = 1200;
            //ev.TripDurationSeconds = 40;
            //ev.TripDistanceMeters = 1200;

            // Create trip shutdown
            TripShutdown ev = new TripShutdown { Header = EventFactory.GetEventHeader(ProtocolBufferTemplate.TripShutdown, _settings.UnitId, DateTime.UtcNow) };


            ev.TripId = 12;
            ev.TripStartDelaySeconds= 4;
			ev.GreenTimePercent = 10;
			ev.TripDurationSeconds = 3600;
			ev.TripDistanceMeters = 2000;
			



            // serialize event
            byte[] eventData;
			using (var ms = new MemoryStream())
			{
				ProtoBuf.Serializer.Serialize(ms, ev);
				eventData = ms.ToArray();
			}
			
			Logger.Info(CultureInfo.InvariantCulture, "NonTripPosition Event Data: {0}", Utils.AsHexString(eventData));

			var apiClient = new ThirdPartyGatewayApiClient(_settings);
			var messageBatch = new MessageBatch();
			messageBatch.AddMessage(new Message
			{
				UnitId = _settings.UnitId,
				TemplateId = ev.Header.TemplateId,
				Data = eventData
			});

			SendMessagesResult result = apiClient.SendMessages(messageBatch);
			if (result.Success)
			{
				bool allMessagesSent = result.Results.All(v => v.Result.Equals("OK", StringComparison.InvariantCultureIgnoreCase));
				if (allMessagesSent)
				{
					Logger.Info(CultureInfo.InvariantCulture, "All messages have been sent: {0}", result);
				}
				else
				{
					Logger.Warn(CultureInfo.InvariantCulture, "Not all messages have been sent: {0}", result);
				}
			}
			else
			{
				Logger.Warn(CultureInfo.InvariantCulture, "Messages were not sent: {0}", result);
			}
		}
	}
}
