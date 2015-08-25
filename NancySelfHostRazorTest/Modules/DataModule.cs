using System;
using Nancy;
using System.Data;

namespace NancyTest
{
	public class DataModule : Nancy.NancyModule
	{
		public DataModule(): base("/data")
		{
			Get["/"] = parameters => {

				DataTable actors = Actors.Retrieve();

				return View["Index", actors];
			};
		}
	}
}

