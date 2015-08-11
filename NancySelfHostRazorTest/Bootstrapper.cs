using System.Collections.Generic;
using Nancy.ViewEngines.Razor;

namespace NancyTest
{
	using Nancy;
	using Nancy.TinyIoc;
	using Nancy.Bootstrapper;

	public class Bootstrapper : DefaultNancyBootstrapper
	{
		protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
		{
			base.ApplicationStartup(container, pipelines);

			StaticConfiguration.DisableErrorTraces = false;

		}
	}
		
}