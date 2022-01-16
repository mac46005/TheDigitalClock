﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public class DigitalClockViewModel : BaseViewModel
    {
        DispatcherTimer _timer = new DispatcherTimer();



        private string _theDate = "This bitch";

        public string TheDate
        {
            get { return _theDate; }
            set 
            { 
                _theDate = value;
                OnPropertyChanged(TheDate);
            }
        }


        private string _theTime = "Dont be working correctly...:(";

        public string TheTime
        {
            get { return _theTime; }
            set 
            {
                _theTime = value;
                OnPropertyChanged(TheTime);
            }
        }



        public DigitalClockViewModel()
        {
            _timer.Interval = new TimeSpan(0, 0, 1);
            //_timer.Tick += _timer_Tick;
            _timer.Start();
        }





        private void _timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TheDate = dateTime.ToString("D");
            TheTime = $"{dateTime.Hour.ToString("D2")} : {dateTime.Minute.ToString("D2")} : {dateTime.Minute.ToString("D2")}";
        }
    }
}
