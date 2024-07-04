using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmCTK.ViewModels;

namespace MvvmCTK.Views
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
