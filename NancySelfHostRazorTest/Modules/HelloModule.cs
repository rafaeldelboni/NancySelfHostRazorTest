using System;
using Nancy;

namespace NancyTest
{
	public class HelloModule : Nancy.NancyModule
	{
		public HelloModule(): base("/hello")
		{
			Get["/"] = parameters => {
				return View["Index"];
			};
		}
	}
}

