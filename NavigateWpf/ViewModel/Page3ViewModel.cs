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
    public class Page3ViewModel : ObservableObject
    {
        //private readonly MainWindow _mainWindow;
        //private readonly Page1ViewModel _page1ViewModel;
        //private readonly Page2ViewModel _page2ViewModel;
        public Page3ViewModel()
        {
            //_mainWindow = mainWindow;
            //_page1ViewModel = page1ViewModel;
            //_page2ViewModel = page2ViewModel;
            PageForward = new RelayCommand(PageFrw);  
            PageBackward = new RelayCommand(PageBck);  
        }

        public IRelayCommand PageForward { get; }
        private void PageFrw()
        {
            //_mainWindow.Content = new Page1View();
            //_mainWindow.DataContext = _page1ViewModel;
        }

        public IRelayCommand PageBackward { get; }
        private void PageBck()
        {
            //_mainWindow.Content = new Page2View();
            //_mainWindow.DataContext = _page2ViewModel;
        }

    }
}
