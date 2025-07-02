using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace NavigateWpf.ViewModel
{
    public partial class Page3ViewModel : ObservableObject
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
