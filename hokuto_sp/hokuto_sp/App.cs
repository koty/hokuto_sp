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

        protected override async void OnStart()
        {
            // Handle when your app starts
			var mainPage = new MainPage();
			var vm = new MainPageViewModel();
			mainPage.BindingContext = vm;
			MainPage = mainPage;
			var client = new HttpClient();
			var json = await client.GetStringAsync("https://b-sw.co/hokuto/hokuto.json");
			var o = JsonConvert.DeserializeObject<Envelope>(json);
			vm.Recs = new ObservableCollection<ScheduleRec>(o.results);
			vm.MyName = "こんにちは。2";
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
