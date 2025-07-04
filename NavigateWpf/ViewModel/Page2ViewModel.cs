using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigateWpf.Services;
using NavigateWpf.View;
using NavigateWpf.View.FramePages;

namespace NavigateWpf.ViewModel
{
    public partial class Page2ViewModel(INavigationService navigationService) : ObservableObject
    {

        private readonly INavigationService _navigation = navigationService;

        // CONTENT NAVIGATION

        [RelayCommand]
        private void Page1() => _navigation.NavigateToView<Page1View>();


        [RelayCommand]
        private void Page2() => _navigation.NavigateToView<Page2View>();

        [RelayCommand]
        private void Page3() => _navigation.NavigateToView<Page3View>();



        // FRAME NAVIGATION

        [RelayCommand]
        private void Frame1() => _navigation.NavigateToPage<FramePage1>();


        [RelayCommand]
        private void Frame2() => _navigation.NavigateToPage<FramePage2>();




    }
}
