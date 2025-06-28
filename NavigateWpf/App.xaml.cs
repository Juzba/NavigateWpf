using Microsoft.Extensions.DependencyInjection;
using NavigateWpf.View;
using NavigateWpf.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace NavigateWpf
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; } = default!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();


            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();

            mainWindow.Show();
            mainWindow.Content = new Page1View();
            mainWindow.DataContext = ServiceProvider.GetRequiredService<Page1ViewModel>(); 
        }

        
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<Page1ViewModel>();
            services.AddSingleton<Page2ViewModel>();
            services.AddSingleton<Page3ViewModel>();
        }





    }

}
