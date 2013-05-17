namespace Log4NetExample
{
	using System;
	using System.IO;
	using System.Reflection;
	using log4net;
	using log4net.Config;

	class Program
	{
		private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		static void Main(string[] args)
		{
			Console.WriteLine("Starting...");

			//log4net
			//XmlConfigurator.ConfigureAndWatch(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config")));
			//XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));
			XmlConfigurator.Configure();

			_log.Info("I'm logging something!");

			var testClass = new TestClass();
			testClass.ImAnotherClass();

			Console.WriteLine("Done.");
			Console.ReadLine();
		}
	}
}
