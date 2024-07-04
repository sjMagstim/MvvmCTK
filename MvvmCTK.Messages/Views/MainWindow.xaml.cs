using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmCTK.Messages.ViewModels;

namespace MvvmCTK.Messages.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            DataContext = Ioc.Default.GetRequiredService<MainWindowViewModel>();
            InitializeComponent();
        }
    }
}