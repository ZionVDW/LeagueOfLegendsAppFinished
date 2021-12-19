using LeagueOfLegendsApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsApp.View.ViewModel
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyProperyChanged(string info)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        string region;
        public  string Region
        {
            get { return region; }
            set { region = value; Constants.Region = value; NotifyProperyChanged("Region"); }
        }

        string summonerName;
        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; NotifyProperyChanged("SummonerName"); }
        }

    }
}
