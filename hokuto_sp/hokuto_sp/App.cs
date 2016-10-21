using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace hokuto_sp
{
    public class App : Application
    {
        public App()
        {
			// The root page of your application
        }

        protected override void OnStart()
        {
            // Handle when your app starts
			var mainPage = new MainPage();
			var vm = new MainPageViewModel();
			mainPage.BindingContext = vm;
			MainPage = mainPage;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
