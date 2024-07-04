using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MvvmCTK.Services;
using MvvmCTK.ViewModels;

namespace MvvmCTK
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICarCollection, MemoryCarCollection>()
                .AddTransient<MainViewModel>()
                .BuildServiceProvider();
            
            Ioc.Default.ConfigureServices(serviceProvider);
        }
    }
}
