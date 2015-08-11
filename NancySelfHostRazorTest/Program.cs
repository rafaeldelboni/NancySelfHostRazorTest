using System;
using Nancy.Hosting.Self;
using System.Diagnostics;

namespace NancyTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// https://github.com/squidge/events/
			var uris = new[] {
				new Uri("http://localhost:8888")
			};
			var hostConfig = new HostConfiguration();

			var nancyHost = new NancyHost(hostConfig, uris);

			nancyHost.Start();

			Console.WriteLine("Nancy now listening - navigating to http://localhost:8888/. Press enter to stop");
			Process.Start("http://localhost:8888/");
			Console.ReadKey();

			nancyHost.Stop();

			Console.WriteLine("Stopped. Good bye!");
		}
	}
}
