using System;
using Scope.FiveC.Protocol.Events;
using Scope.FiveC.Protocol.Events.Enums;

namespace Scope.FiveC.Protocol
{
	public interface IProtocolBufferEvent
	{
		EventHeader Header { get; set; }
		void Validate();
		ProtocolBufferTemplate Template { get; }
		byte MessageId { get; }
		int TemplateId { get; }
		string UnitId { get; set; }
		DateTime? UtcTimestamp { get; set; }
		decimal? Latitude { get; set; }
		decimal? Longitude { get; set; }
		string Description { get; set; }
		InputStatusType? InputStatus { get; set; }
		OutputStatusType? OutputStatus { get; set; }
		uint? Odometer { get; set; }
		uint? DriverKeyCode { get; set; }
		ushort? Speed { get; set; }
		ushort? Direction { get; set; }
		GeneralStatusType? GeneralStatus { get; set; }
	}
}
