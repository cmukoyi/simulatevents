using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Common
{
	/// <summary>
	/// Class for common utility functions
	/// </summary>
	public static class Utils
	{
		/// <summary>
		/// Get entry assembly file version
		/// </summary>
		/// <returns></returns>
		public static string GetApplicationFileVersion()
		{
			Assembly a = Assembly.GetEntryAssembly();
			FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(a.Location);
			return string.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart);
		}


		/// <summary>
		/// Convert binary data as hex string (0x01, 0x0A => "010A")
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string AsHexString(byte[] data)
		{
			var sb = new StringBuilder();
			foreach (byte b in data)
				sb.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);

			return sb.ToString();
		}
	}
}
