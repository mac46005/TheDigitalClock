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
            set 
            {
                _dateText = value;
                OnPropertyChanged(DateText);
            }
        }


        private string _timeText;

        public string TimeText
        {
            get { return _timeText; }
            set 
            {
                _timeText = value;
                OnPropertyChanged(TimeText);
            }
        }

        public DigitalClockViewModel()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
