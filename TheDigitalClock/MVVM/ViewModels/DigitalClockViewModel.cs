using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TheDigitalClock.MVVM.ViewModels
{
    public class DigitalClockViewModel : BaseViewModel
    {
        DispatcherTimer _timer;

        private string _dateText;

        public string DateText
        {
            get { return _dateText; }
            set { _dateText = value; }
        }

        private string _timeText;

        public string TimeText
        {
            get { return _timeText; }
            set { _timeText = value; }
        }


        public DigitalClockViewModel()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
            DateText = $"{dt.ToString("D")}";
            TimeText = $"{dt.Hour.ToString("D2")}:{dt.Minute.ToString("D2")}:{dt.Second.ToString("D2")}";
            OnPropertyChanged("DateText");
            OnPropertyChanged("TimeText");
        }
    }
}
