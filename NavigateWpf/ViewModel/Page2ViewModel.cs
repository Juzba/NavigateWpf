using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NavigateWpf.ViewModel
{
    public partial class Page2ViewModel : ObservableObject
    {
        [RelayCommand]
        private void Page1()
        {
            MessageBox.Show("page1");
        }
        [RelayCommand]
        private void Page2()
        {
            MessageBox.Show("page2");
        }
        [RelayCommand]
        private void Page3()
        {
            MessageBox.Show("page3");
        }
    }
}
