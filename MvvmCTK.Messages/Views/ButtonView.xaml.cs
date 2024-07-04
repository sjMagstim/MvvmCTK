using System.Windows.Controls;
using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmCTK.Messages.ViewModels;

namespace MvvmCTK.Messages.Views
{
    public partial class ButtonView : UserControl
    {
        public ButtonView()
        {
            DataContext = Ioc.Default.GetRequiredService<ButtonViewModel>();
            InitializeComponent();
        }
    }
}