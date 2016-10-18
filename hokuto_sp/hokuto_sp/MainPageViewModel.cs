using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace hokuto_sp
{
	public class Rec: INotifyPropertyChanged
	{
		public string Name { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
	public class MainPageViewModel: INotifyPropertyChanged
	{
		public ObservableCollection<Rec> Recs { get; private set; }
		public MainPageViewModel()
		{
			this.Recs = new ObservableCollection<Rec>(new [] {
				new Rec() { Name = "にゃー"},
				new Rec() { Name = "わんわん"},
				new Rec() { Name = "ヒヒーン"}
			});
			this.MyName = "こんにちは。";
		}
		public string MyName { get; private set; }
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
