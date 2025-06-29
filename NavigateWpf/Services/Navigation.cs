using NavigateWpf.ViewModel;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace NavigateWpf.Services
{
    public interface INavigation   
    {
        void NavigateTo(string modelView);
    }

    public class Navigation : INavigation
    {
        private readonly MainWindow _mainWindow;
        private readonly IServiceProvider _serviceProvider;
        public Navigation(MainWindow mainWindow, IServiceProvider serviceProvider)
        {
            _mainWindow = mainWindow;
            _serviceProvider = serviceProvider;
        }
        public void NavigateTo(string modelView)
        {
            switch(modelView)
            {
                case "Page1ViewModel":
                    _mainWindow.Content = new Page1View();
                    _mainWindow.DataContext = _serviceProvider.GetRequiredService<Page1ViewModel>();
                    break;
                case "Page2ViewModel":
                    _mainWindow.Content = new Page2View();
                    _mainWindow.DataContext = _serviceProvider.GetRequiredService<Page2ViewModel>();
                    break;
                case "Page3ViewModel":
                    _mainWindow.Content = new Page3View();
                    _mainWindow.DataContext = _serviceProvider.GetRequiredService<Page3ViewModel>();
                    break;
                default:
                    throw new ArgumentException("Invalid model view type", nameof(modelView));
            }
        }
    }
}
