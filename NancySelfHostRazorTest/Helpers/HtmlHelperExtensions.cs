using System;
using Nancy.ViewEngines.Razor;
using Nancy.ViewEngines;
using System.IO;
using Nancy.Security;

namespace NancyTest
{
	public static class HtmlHelperExtensions
	{
		public static BeginFormObject BeginForm<t>(this HtmlHelpers<t> helpers, NancyRazorViewBase view)
		{
			return new BeginFormObject("<form method=\"post\">", view);
		}

		public class BeginFormObject : IDisposable
		{
			private NancyRazorViewBase view;
			public BeginFormObject(string markup, NancyRazorViewBase view)
			{
				this.view = view;
				view.WriteLiteral(markup);
			}

			public void Dispose()
			{
				view.WriteLiteral("</form>");
			}
		}
	}
}

