using System;
using Nancy;

namespace NancyTest
{
	public class HomeModule : Nancy.NancyModule
	{
		public HomeModule()
		{
			/*
			Create -> Post
			Read   -> Get
			Update -> Put
			Delete -> Delete
			*/

			Get["/"] = parameters => {
				var model = new ViewModel {Message = "Hello from the server"};

				return View["Index", model];
			};

		}
	}
}

