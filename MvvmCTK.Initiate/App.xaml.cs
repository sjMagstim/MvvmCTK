using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MvvmCTK.Initiate.Services;
using MvvmCTK.Initiate.ViewModels;

namespace MvvmCTK.Initiate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
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