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
        private readonly DispatcherTimer _timer;

        private string _clockText;

        public string ClockText
        {
            get { return _clockText; }
            set { _clockText = value; }
        }


        public DigitalClockViewModel()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0,0,1);
            _timer.Tick += _timer_Tick;
        }

        private  void _timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            ClockText = $"{dt.ToString("D")}\n" + 
                $"{dt.Hour.ToString("D2")}:{dt.Minute.ToString("D2")}:{dt.Second.ToString("D2")}";
        }
    }
}
