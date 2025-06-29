using NavigateWpf.ViewModel;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateWpf.Services
{
    public interface INavigation   
    {
        void NavigateTo();
    }

    public class Navigation : INavigation
    {
        private readonly MainWindow _mainWindow;
        private readonly Page2ViewModel _page2ViewModel;
        public Navigation(MainWindow mainWindow, Page2ViewModel page2ViewModel)
        {
            _mainWindow = mainWindow;
            _page2ViewModel = page2ViewModel;
        }
        public void NavigateTo()
        {
            _mainWindow.Content = new Page2View();
            _mainWindow.DataContext = _page2ViewModel;
        }
    }
}
