using CommunityToolkit.Mvvm.ComponentModel;
using MvvmCTK.Services;

namespace MvvmCTK.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ICarCollection _carCollection;

        public MainViewModel(){}
        public MainViewModel(ICarCollection carCollection)
        {
            _carCollection = carCollection;
        }
    }
}
