using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NavigateWpf.View;
using System.Windows.Controls;

namespace NavigateWpf.Services
{
    public interface INavigationService
    {
        void NavigateToView<TUserControl>() where TUserControl : UserControl;
        void NavigateToPage<TPage>() where TPage : Page;
    }

    public class NavigationService(IHost host, MainWindow mainWindow) : INavigationService
    {
        private readonly IHost _host = host;
        private readonly MainWindow _mainWindow = mainWindow;


        public void NavigateToView<TUserControl>() where TUserControl : UserControl
        {
            var view = _host.Services.GetRequiredService<TUserControl>();
            _mainWindow.Content = view;
        }


        public void NavigateToPage<TPage>() where TPage : Page
        {
            var userControl = _host.Services.GetRequiredService<Page2View>();
            var page = _host.Services.GetRequiredService<TPage>();
            userControl.FrameMainBox.Navigate(page);

        }
    }
}
