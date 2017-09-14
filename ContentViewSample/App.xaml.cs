using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


using Xamarin.Forms;

namespace ContentViewSample
{
	public partial class App : Application
	{
        ContentViews cv = new ContentViews();
        ChangePwd cp = new ChangePwd();
        public App ()
		{
			InitializeComponent();

			MainPage = new ContentViewSample.ChangePwd();
		}

		protected override void OnStart ()
		{
            if (Application.Current.Properties.ContainsKey("userName"))
            {
                var username = Application.Current.Properties["userName"].ToString();
                cp.DisplayAlert(username, "Hi user", "OK");
                App.Current.SavePropertiesAsync();
            }
            else
            {
                //Application.Current.Properties.Add("userName", cv.TxtUserName);
                Debug.WriteLine("Found");
            }
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
            Application.Current.Properties["userName"] = cv.TxtUserName;
            // Handle when your app sleeps
        }

		protected override void OnResume ()
		{
            // Handle when your app resumes
            //if (Application.Current.Properties.ContainsKey("userName"))
            //{
            //    var username = Application.Current.Properties["userName"].ToString();
            //    cp.DisplayAlert(username, "Hi user", "OK");
            //    App.Current.SavePropertiesAsync();
            //}
            //else
            //{
            //    Application.Current.Properties.Add("userName", cv.TxtUserName);
            //}
        }
	}
}
