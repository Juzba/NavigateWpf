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
    public class Page2ViewModel : ObservableObject
    {
        public Page2ViewModel()
        {
            PageForward = new RelayCommand(PageFrw);
            PageBackward = new RelayCommand(PageBck);
        }

        public IRelayCommand PageForward { get; }
        private void PageFrw()
        {
            //_mainWindow.Content = new Page3View();
            //_mainWindow.DataContext = _page3ViewModel;
        }

        public IRelayCommand PageBackward { get; }
        private void PageBck()
        {
            //_mainWindow.Content = new Page1View();
            //_mainWindow.DataContext = _page3ViewModel;
        }

    }
}
