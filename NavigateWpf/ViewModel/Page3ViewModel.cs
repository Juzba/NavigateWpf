using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigateWpf.Services;

namespace NavigateWpf.ViewModel
{
    public class Page3ViewModel : ObservableObject
    {
        private readonly Navigation _navigation;
        public Page3ViewModel(Navigation navigation)
        {
            _navigation = navigation;
            PageForward = new RelayCommand(PageFrw);
            PageBackward = new RelayCommand(PageBck);
        }

        public IRelayCommand PageForward { get; }
        private void PageFrw()
        {
            _navigation.NavigateTo("Page1ViewModel");
        }

        public IRelayCommand PageBackward { get; }
        private void PageBck()
        {
            _navigation.NavigateTo("Page2ViewModel");
        }

    }
}
