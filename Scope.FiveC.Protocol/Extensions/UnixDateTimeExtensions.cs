using System;

namespace Scope.FiveC.Protocol.Extensions
{
	public static class UnixDateTimeExtensions
	{
		/// <summary>
		/// Gets DateTime from the unix UTC milliseconds (since 1970.01.01).
		/// </summary>
		/// <param name="milliseconds">The milliseconds.</param>
		public static DateTime? FromUnixMillisecondsUtc(long? milliseconds)
		{
			if (milliseconds == null)
				return null;
			return DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc).AddMilliseconds(milliseconds.Value);
		}

		/// <summary>
		/// Converts UTC DateTime to unix milliseconds (since 1970.01.01).
		/// </summary>
		/// <param name="utcDateTime">The UTC date time.</param>
		public static long? ToUnixMillisecondsUtc(this DateTime? utcDateTime)
		{
			if (utcDateTime == null)
				return null;
			return (long)utcDateTime.Value
				.ToUniversalTime()
				.Subtract(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc))
				.TotalMilliseconds;
		}


		/// <summary>
		/// Gets DateTime from the unix UTC seconds (since 1970.01.01).
		/// </summary>
		/// <param name="seconds">The seconds.</param>
		public static DateTime? FromUnixSecondsUtc(ulong? seconds)
		{
			if (seconds == null)
				return null;
			return DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc).AddSeconds(seconds.Value);
		}

		/// <summary>
		/// Converts UTC DateTime to unix seconds (since 1970.01.01).
		/// </summary>
		/// <param name="utcDateTime">The UTC date time.</param>
		public static ulong? ToUnixSecondsUtc(this DateTime? utcDateTime)
		{
			if (utcDateTime == null)
				return null;
			return (ulong)utcDateTime.Value
				.ToUniversalTime()
				.Subtract(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc))
				.TotalSeconds;
		}
	}
}
