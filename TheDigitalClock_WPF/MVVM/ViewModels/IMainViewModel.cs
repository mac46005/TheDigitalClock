using TheDigitalClock_WPF.Core.MVVMHelper;

namespace TheDigitalClock_WPF.MVVM.ViewModels
{
    public interface IMainViewModel : IViewModel
    {
        object CurrentView { get; set; }
    }
}