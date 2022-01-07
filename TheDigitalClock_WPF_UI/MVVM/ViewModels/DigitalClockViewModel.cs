using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDigitalClock_WPF_UI.MVVM.Models;

namespace TheDigitalClock_WPF_UI.MVVM.ViewModels
{
    public class DigitalClockViewModel : Screen
    {
        DigitalClockModel _digitalClock = new DigitalClockModel();
        public DigitalClockViewModel()
        {
            _digitalClock.Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Date = _digitalClock.CurrentDateTime.ToString("M")
                + Environment.NewLine
                + _digitalClock.CurrentDateTime.ToString("yyyy");
            Time = _digitalClock.CurrentDateTime.ToString("T");
        }

        private string _date;

        public string Date
        {
            get { return _date; }
            set 
            {
                _date = value;
                NotifyOfPropertyChange(() => Date);
            }
        }
        private string _time;

        public string Time
        {
            get { return _time; }
            set 
            {
                _time = value;
                NotifyOfPropertyChange(() => Time);
            }
        }

    }
}
