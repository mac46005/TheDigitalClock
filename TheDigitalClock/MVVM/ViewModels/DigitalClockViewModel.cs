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
            private set { _clockText = value; }
        }


        public DigitalClockViewModel()
        {
            _timer = new DispatcherTimer(DispatcherPriority.Render);
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (o, e) =>
            {
                OnPropertyChanged("ClockText");
                DateTime dt = DateTime.Now;
                ClockText = $"{dt.ToString("D")}{Environment.NewLine}" +
                    $"{dt.Hour.ToString("D2")}:{dt.Minute.ToString("D2")}:{dt.Second.ToString("D2")}";
                
            };
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
