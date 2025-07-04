using CommunityToolkit.Mvvm.ComponentModel;
using NavigateWpf.Services;

namespace NavigateWpf.ViewModel
{
    public partial class ApplicationViewModel(NavigationService navigationService) : ObservableObject
    {
        private readonly INavigationService _navigationService = navigationService;


        //[ObservableProperty]
        //private object currentPage;












    }
}
