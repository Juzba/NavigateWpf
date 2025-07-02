using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NavigateWpf.ViewModel;
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
                services.AddTransient<Page1ViewModel>();
                services.AddTransient<Page2ViewModel>();
                services.AddTransient<Page3ViewModel>();


            }).Build();
        }


        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();

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
