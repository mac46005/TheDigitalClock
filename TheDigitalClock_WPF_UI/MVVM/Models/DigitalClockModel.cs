using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TheDigitalClock_WPF_UI.MVVM.Models
{
    public class DigitalClockModel
    {
        public DispatcherTimer Timer = new DispatcherTimer();
        public DigitalClockModel()
        {
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        public DateTime CurrentDateTime { get; set; }



        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentDateTime = DateTime.Now;
        }
    }
}
