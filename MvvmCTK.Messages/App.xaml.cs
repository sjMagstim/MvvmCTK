using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MvvmCTK.Messages.ViewModels;

namespace MvvmCTK.Messages
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ButtonViewModel>()
                .AddTransient<CountViewModel>()
                .AddTransient<MainWindowViewModel>()
                .BuildServiceProvider();
            
            Ioc.Default.ConfigureServices(serviceProvider);
        }
    }
}