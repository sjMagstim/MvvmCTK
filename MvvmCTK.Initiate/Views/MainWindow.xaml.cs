using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmCTK.Initiate.ViewModels;

namespace MvvmCTK.Initiate.Views
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetRequiredService<MainViewModel>();
        }
    }
}
