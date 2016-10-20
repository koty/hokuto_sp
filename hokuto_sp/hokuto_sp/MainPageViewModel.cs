using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http;

namespace hokuto_sp
{
	public class Rec: INotifyPropertyChanged
	{
		public string Name { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
	public class MainPageViewModel: INotifyPropertyChanged
	{
		private ObservableCollection<ScheduleRec> _Recs;
		public ObservableCollection<ScheduleRec> Recs
		{
			get
			{
				return _Recs;
			}
			set
			{
				_Recs = value;
				NotifyPropertyChanged("Recs");
			}
		}
		//public ObservableCollection<Rec> Recs { get; private set; }
		public MainPageViewModel()
		{
		}
		private string _MyName;
		public string MyName {
			get
			{
				return _MyName;
			}
			set
			{
				_MyName = value;
				NotifyPropertyChanged("MyName");
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged(String propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	public class Envelope
	{
		public ScheduleRec[] results { get; set; }
	}
	public class ScheduleRec: INotifyPropertyChanged
	{
		public string url { get; set; }
		public string time_from { get; set; }
		public string room_name { get; set; }
		public string date { get; set; }
		public string time_to { get; set; }
		public string subject { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
