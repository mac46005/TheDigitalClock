using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TheDigitalClock.MVVM.Models;

namespace TheDigitalClock.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private CollectionViewSource MenuItemsCollection;

        public ICollectionView SourceCollection => MenuItemsCollection.View;


        public MainViewModel()
        {
            ObservableCollection<NavigationItem> navigationItems = new ObservableCollection<NavigationItem>
            {
                new NavigationItem{NavName = "Clock", NavImage = @"Assets/Images/Clock.png"},
                new NavigationItem{NavName = "Settings",NavImage = @"Assets/Images/Settings.png"},
                new NavigationItem{NavName = "Close",NavImage = @"Assets/Images/Close.png"}
            };


            MenuItemsCollection = new CollectionViewSource { Source = navigationItems };

            ViewModel = new DigitalClockViewModel();
        }



        private object _viewModel;

        public object ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

    }
}
