using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NavigateWpf.Services;
using NavigateWpf.View;
using NavigateWpf.View.FramePages;
using NavigateWpf.ViewModel;
using NavigateWpf.ViewModel.FrameViewModel;
using System.Windows;

namespace NavigateWpf
{
    public partial class App : Application
    {
        public IHost AppHost { get; private set; } = default!;

        public App()
        {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices((_, services) =>
            {

                services.AddSingleton<MainWindow>();
                services.AddSingleton<ApplicationViewModel>();
                services.AddSingleton<INavigationService, NavigationService>();

                services.AddTransient<Page1ViewModel>();
                services.AddTransient<Page2ViewModel>();
                services.AddTransient<Page3ViewModel>();
                services.AddTransient<FramePage1ViewModel>();
                services.AddTransient<FramePage2ViewModel>();


                services.AddSingleton<Page2View>(provider =>
                {
                    var page2View = ActivatorUtilities.CreateInstance<Page2View>(provider);
                    var framePage1 = provider.GetRequiredService<FramePage1>();
                    page2View.FrameMainBox.Navigate(framePage1);

                    return page2View;
                });

                services.AddTransient<Page1View>();
                services.AddTransient<Page3View>();
                services.AddTransient<FramePage1>();
                services.AddTransient<FramePage2>();
            }).Build();
        }


        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();

            var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
            mainWindow.Content = AppHost.Services.GetRequiredService<Page1View>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            AppHost.Dispose();

            base.OnExit(e);
        }
    }
}
