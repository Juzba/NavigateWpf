using Microsoft.Extensions.DependencyInjection;
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
        void NavigateTo<TPage>() where TPage : Page;
    }

    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Frame _frame;

        public NavigationService(IServiceProvider serviceProvider, Frame frame)
        {
            _serviceProvider = serviceProvider;
            _frame = frame;
        }

        public void NavigateTo<TPage>() where TPage : Page
        {
            var page = _serviceProvider.GetRequiredService<TPage>();
            _frame.Navigate(page);
        }
    }
}
