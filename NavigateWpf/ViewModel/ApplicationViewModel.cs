using CommunityToolkit.Mvvm.ComponentModel;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateWpf.ViewModel
{
    public partial class ApplicationViewModel : ObservableObject
    {
      

        [ObservableProperty]
        private object currentPage = new Page1View();












    }
}
