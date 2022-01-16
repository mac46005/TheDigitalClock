using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using TheDigitalClock_WPF.Core.MVVMHelper;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public class DigitalClockViewModel : BaseViewModel, IDigitalClockViewModel
    {
        DispatcherTimer timer;
        private string _date;
        private string _time;



        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged(Date);
            }
        }

        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged(Time);
            }
        }


        public DigitalClockViewModel()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            var dateTimeNow = DateTime.Now;
            Date = dateTimeNow.ToString("D");
            Time =
                $"{dateTimeNow.Hour.ToString("D2")} : {dateTimeNow.Minute.ToString("D2")} : {dateTimeNow.Minute.ToString("D2")}";
        }
    }
}
