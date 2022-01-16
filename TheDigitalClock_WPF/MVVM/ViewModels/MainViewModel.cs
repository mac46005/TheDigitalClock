using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDigitalClock_WPF.MVVM.Views;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private object _currentViewModel;

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }



        public MainViewModel()
        {
            DigitalClockViewModel vm = new DigitalClockViewModel();
            DigitalClockView v = new DigitalClockView();
            v.DataContext = vm;
            CurrentViewModel = v;

        }
    }
}
