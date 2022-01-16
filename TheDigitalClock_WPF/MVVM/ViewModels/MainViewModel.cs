using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private object _currentViewModel;

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; }
        }



        public MainViewModel()
        {

        }
    }
}
