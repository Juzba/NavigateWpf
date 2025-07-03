using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigateWpf.Services;
using NavigateWpf.View;

namespace NavigateWpf.ViewModel
{
    public partial class Page3ViewModel(INavigationService navigationService) : ObservableObject
    {
        private readonly INavigationService _navigationService = navigationService;



        [RelayCommand]
        private void Page1() => _navigationService.NavigateTo<Page1View>();


        [RelayCommand]
        private void Page2() => _navigationService.NavigateTo<Page2View>();

        [RelayCommand]
        private void Page3() => _navigationService.NavigateTo<Page3View>();
    }
}
