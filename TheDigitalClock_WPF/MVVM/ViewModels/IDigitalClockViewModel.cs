using TheDigitalClock_WPF.Core.MVVMHelper;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public interface IDigitalClockViewModel : IViewModel
    {
        string Date { get; set; }
        string Time { get; set; }
    }
}