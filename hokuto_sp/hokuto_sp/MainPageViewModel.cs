using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http;
using Prism.Mvvm;

namespace hokuto_sp
{
	public class MainPageViewModel: BindableBase
	{
		private ObservableCollection<ScheduleRec> _Recs;
		public ObservableCollection<ScheduleRec> Recs
		{
			get { return _Recs; }
			set { SetProperty(ref _Recs, value); }
		}
		private string _MyName;
		public string MyName
		{
			get { return _MyName; }
			set { SetProperty(ref _MyName, value); }
		}
		public MainPageViewModel()
		{
			Init();
		}
		async void Init()
		{
			var client = new HttpClient();
			var json = await client.GetStringAsync("https://b-sw.co/hokuto/hokuto.json");
			var o = JsonConvert.DeserializeObject<Envelope>(json);
			Recs = new ObservableCollection<ScheduleRec>(o.results);
			MyName = "こんにちは。2";
		}
	}
	public class Envelope
	{
		public ScheduleRec[] results { get; set; }
	}
	public class ScheduleRec: BindableBase
	{
		public string url { get; set; }
		public string time_from { get; set; }
		public string room_name { get; set; }
		public string date { get; set; }
		public string time_to { get; set; }
		public string subject { get; set; }
	}
}
