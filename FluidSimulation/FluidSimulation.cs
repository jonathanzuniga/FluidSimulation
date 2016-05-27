using System;

using Xamarin.Forms;

namespace FluidSimulation
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var template = new Fluid ();
			var page = template.GenerateString ();
			var html = new HtmlWebViewSource { Html = page };

			// The root page of your application.
			MainPage = new ContentPage {
				Content = new WebView () {
					Source = html
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

