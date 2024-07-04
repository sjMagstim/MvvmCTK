using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MvvmCTK.Setup.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = "Sam";

        public void Thing()
        {
            Name = "Thing";
        }

        [RelayCommand]
        private async Task ChangeNameAsync()
        {
            await Task.Delay(2000);
            Name = "Mike";
        }
    }
}