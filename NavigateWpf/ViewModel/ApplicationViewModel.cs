using CommunityToolkit.Mvvm.ComponentModel;
using NavigateWpf.Services;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateWpf.ViewModel
{
    public partial class ApplicationViewModel(NavigationService navigationService) : ObservableObject
    {
        private readonly INavigationService _navigationService = navigationService;


        //[ObservableProperty]
        //private object currentPage;












    }
}
