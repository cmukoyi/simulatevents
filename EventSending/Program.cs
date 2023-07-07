using System;
using System.Globalization;
using Common;
using EventSending.Properties;
using NLog;

namespace EventSending
{
	class Program
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();


		static int Main(string[] args)
		{
			try
			{
				Logger.Info(CultureInfo.InvariantCulture, "EventSending started. Version: {0}", Utils.GetApplicationFileVersion());

				new Application(Settings.Default, args).Run();

				Logger.Info(CultureInfo.InvariantCulture, "Done.");
			}
			catch (Exception ex)
			{
				Logger.Error("Exception in Main.", ex);
				return 1;
			}

			return 0;
		}
	}
}
