using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TheDigitalClock_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Bootstrapper.Start();

            Window window = new MainWindow();

            window.DataContext = Bootstrapper.RootVisual;

            window.Closed += Window_Closed;

            window.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Bootstrapper.Stop();
        }
    }
}
