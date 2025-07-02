using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateWpf.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly Page1View _page1View;

        public MainViewModel(Page1View page1View)
        {
            _page1View = page1View;
            CurrentViewModel = _page1View;
        }

        [ObservableProperty]
        private object currentViewModel;
    }
}
