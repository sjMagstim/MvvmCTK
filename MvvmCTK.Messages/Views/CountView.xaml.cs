using System.Windows.Controls;
using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmCTK.Messages.ViewModels;

namespace MvvmCTK.Messages.Views
{
    public partial class CountView : UserControl
    {
        public CountView()
        {
            DataContext = Ioc.Default.GetRequiredService<CountViewModel>();
            InitializeComponent();
        }
    }
}