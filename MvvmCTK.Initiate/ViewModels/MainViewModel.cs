using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmCTK.Initiate.Services;

namespace MvvmCTK.Initiate.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ICarCollection _carCollection;

        [ObservableProperty]
        private IEnumerable<string> _cars;

        public MainViewModel(){}
        public MainViewModel(ICarCollection carCollection)
        {
            _carCollection = carCollection;
        }

        [RelayCommand]
        private async Task LoadedHandler()
        {
            Cars = await _carCollection.GetAllCarsAsync();
        }
    }
}
