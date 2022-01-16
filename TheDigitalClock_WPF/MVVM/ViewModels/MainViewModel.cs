using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TheDigitalClock_WPF.Core.MVVMHelper;
using TheDigitalClock_WPF.MVVM.Views;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            IViewModel clockVM = Bootstrapper.Resolver<DigitalClockViewModel>();
            CurrentView = clockVM;

        }
    }
}
