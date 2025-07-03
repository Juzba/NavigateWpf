using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NavigateWpf.Services
{
    public interface INavigationService
    {
        void NavigateTo<TUserControl>() where TUserControl : UserControl;
    }

    public class NavigationService(IHost host, MainWindow mainWindow) : INavigationService
    {
        private readonly IHost _host = host;
        private readonly MainWindow _mainwindow = mainWindow;


        public void NavigateTo<TUserControl>() where TUserControl : UserControl
        {
            var page = _host.Services.GetRequiredService<TUserControl>();
            _mainwindow.Content = page;
        }
    }
}
