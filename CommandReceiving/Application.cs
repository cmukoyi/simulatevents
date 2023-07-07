using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CommandReceiving.Properties;
using NLog;
using Scope.FiveC.Protocol.UnitControlRequest;
using ThirdPartyGatewayApi.Api;
using ThirdPartyGatewayApi.Entities;

namespace CommandReceiving
{
	/// <summary>
	/// The main application class for command receiving
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

			var apiClient = new ThirdPartyGatewayApiClient(_settings);
			GetCommandRequestsResult result = apiClient.GetCommandRequests();
			if (result.Success)
			{
				// Command requests received
				Logger.Info(CultureInfo.InvariantCulture, "Command requests recieved: {0}", result);

				foreach (CommandRequest commandRequest in result.CommandRequests)
				{
					var ucr = (UnitControlRequest)Deserialize(commandRequest);
					Logger.Info(CultureInfo.InvariantCulture, "Type: {0}, UnitId: {1}", commandRequest.RequestType, ucr.UnitId);

					if (ucr.Poll != null)
					{
						var values = ucr.Poll.Select(v => string.Format(CultureInfo.InvariantCulture, "{{Type: {0}}}", v.Type));
						Logger.Info(CultureInfo.InvariantCulture, "Poll: {0}", string.Join(",", values));
					}

					if (ucr.Output != null)
					{
						var values = ucr.Output.Select(v => string.Format(CultureInfo.InvariantCulture, "{{Port: {0}, State: {1}, Style: {2}}}", v.Port, v.State, v.Style));
						Logger.Info(CultureInfo.InvariantCulture, "Output: {0}", string.Join(",", values));
					}

					// More unit control requests are available
					// ucr.ActiveRecovery
					// ucr.CanDataPoll
					// ucr.Disable
					// ucr.ExecuteProfile
				}
			}
			else if (result.Code == "MessagesNotFound")
			{
				// No command request available
				Logger.Info(CultureInfo.InvariantCulture, "No Command requests");
			}
			else
			{
				// Error or no command request available
				Logger.Warn(CultureInfo.InvariantCulture, "Error while receiving Command requests: {0}", result);
			}
		}


		/// <summary>
		/// Deserialize command request from proto buffer
		/// </summary>
		/// <param name="commandRequest"></param>
		/// <returns></returns>
		private object Deserialize(CommandRequest commandRequest)
		{
			using (var ms = new MemoryStream(commandRequest.Data))
			{
				switch (commandRequest.RequestType)
				{
					case "UnitControlRequest":
						return ProtoBuf.Serializer.Deserialize<UnitControlRequest>(ms);

					default:
						throw new NotSupportedException("RequestType is not supported: " + commandRequest.RequestType);
				}
			}
		}
	}
}
