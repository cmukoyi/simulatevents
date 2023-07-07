using System;
using System.Globalization;
using System.Net;
using Common;
using NLog;
using RestSharp;
using ThirdPartyGatewayApi.Entities;

namespace ThirdPartyGatewayApi.Api
{
	public class ThirdPartyGatewayApiClient
	{
		private const string HeaderContentTypeKey = "Content-Type";
		private const string HeaderAcceptKey = "Accept";
		private const string HeaderDateKey = "Date";
		private const string ContentTypeJson = "application/json";
		private const string GmtDateFormat = "r"; // Sat, 16 Aug 2008 10:38:39 GMT
		
		private const string SendMessagesRequestPath = "api/v1/messages";
		private const string GetCommandRequestsRequestPath = "api/v1/requests";

		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
		private readonly IThirdPartyGatewayApiClientSettings _settings;


		/// <summary>
		/// Class for communication with MProfiler's Third Party Gateway Api
		/// </summary>
		/// <param name="settings"></param>
		public ThirdPartyGatewayApiClient(IThirdPartyGatewayApiClientSettings settings)
		{
			_settings = settings;
		}


		/// <summary>
		/// Send a batch of messages
		/// </summary>
		/// <param name="messageBatch"></param>
		/// <returns></returns>
		public SendMessagesResult SendMessages(MessageBatch messageBatch)
		{
			Logger.Debug("SendMessages: BatchId: {0}, MessageCount: {1}", messageBatch.BatchId, messageBatch.Messages.Count);

			IRestRequest request = new RestRequest(SendMessagesRequestPath, Method.POST);
			request.RequestFormat = DataFormat.Json;
			request.JsonSerializer = new CustomJsonSerializer();
			request.AddHeader(HeaderContentTypeKey, ContentTypeJson);
			request.AddHeader(HeaderAcceptKey, ContentTypeJson);
			request.AddHeader(HeaderDateKey, DateTime.UtcNow.ToString(GmtDateFormat, CultureInfo.InvariantCulture));
			request.AddJsonBody(messageBatch);

			Logger.Debug("Connecting to '{0}' with ServiceProviderName '{1}'", _settings.BaseUrl, _settings.ServiceProviderName);
			IRestResponse<SendMessagesResult> response = NewRestClient.Execute<SendMessagesResult>(request);

			Logger.Debug("ResponseStatus: {0}", response.ResponseStatus);
			if (response.ResponseStatus != ResponseStatus.Completed)
			{
				Logger.Warn("Could not send messages. ResponseStatus: {0}, ErrorMessage: {1}", response.ResponseStatus, response.ErrorMessage);
				return response.Data;
			}

			if (response.StatusCode == HttpStatusCode.OK)
			{
				Logger.Debug("StatusCode: {0}: {1}", response.StatusCode, response.StatusDescription);
				response.Data.Success = true;
				return response.Data;
			}

			Logger.Warn("Could not send messages. StatusCode: {0}: {1}", response.StatusCode, response.StatusDescription);
			return response.Data;
		}


		/// <summary>
		/// Get command requests for the specified service provider units
		/// </summary>
		/// <returns></returns>
		public GetCommandRequestsResult GetCommandRequests()
		{
			Logger.Debug("GetCommandRequests");

			IRestRequest request = new RestRequest(GetCommandRequestsRequestPath, Method.GET);
			request.RequestFormat = DataFormat.Json;
			request.JsonSerializer = new CustomJsonSerializer();
			request.AddHeader(HeaderContentTypeKey, ContentTypeJson);
			request.AddHeader(HeaderAcceptKey, ContentTypeJson);

			Logger.Debug("Connecting to '{0}' with ServiceProviderName '{1}'", _settings.BaseUrl, _settings.ServiceProviderName);
			IRestResponse<GetCommandRequestsResult> response = NewRestClient.Execute<GetCommandRequestsResult>(request);

			Logger.Debug("ResponseStatus: {0}", response.ResponseStatus);
			if (response.ResponseStatus != ResponseStatus.Completed)
			{
				Logger.Warn("Could not get command requests. ResponseStatus: {0}, ErrorMessage: {1}", response.ResponseStatus, response.ErrorMessage);
				return response.Data;
			}

			if (response.StatusCode == HttpStatusCode.OK)
			{
				Logger.Debug("StatusCode: {0}: {1}", response.StatusCode, response.StatusDescription);
				response.Data.Success = true;
				return response.Data;
			}

			Logger.Warn("Could not get command requests. StatusCode: {0}: {1}", response.StatusCode, response.StatusDescription);
			return response.Data;
		}


		/// <summary>
		/// Create a new rest client with basic authenitcation and json serialization
		/// </summary>
		private IRestClient NewRestClient
		{
			get
			{
				var authenticator = new HttpBasicAuthenticator(_settings.ServiceProviderName, _settings.ServiceProviderApiKey);
				RestClient restClient = new RestClient(_settings.BaseUrl) { Authenticator = authenticator };
				restClient.AddHandler(ContentTypeJson, new CustomJsonSerializer());

				return restClient;
			}
		}

	}
}
