using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace appCenterTestApp
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new appCenterTestApp.MainPage();
		}

		protected override void OnStart ()
		{
		    AppCenter.Start("android=27993508-c148-409b-95cf-d2dd4d965f77;" + "uwp=0cf6d621-48d9-4280-bcc8-e14b19cbe1ce;" +
                            "ios=f1d4dc5b-3b4c-4c69-ad25-0c8dc46d2baa;", typeof(Analytics), typeof(Crashes));

            Analytics.TrackEvent("Application start");
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
            Analytics.TrackEvent("Application hidden");
            // Handle when your app sleeps
        }

		protected override void OnResume ()
		{
            Analytics.TrackEvent("Application resumed");
            // Handle when your app resumes
        }
	}
}
