using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MvvmCTK.Messages.Messages;

namespace MvvmCTK.Messages.ViewModels
{
    public partial class ButtonViewModel : ObservableObject
    {
        [ObservableProperty] 
        private int _count;

        [RelayCommand]
        private void IncrementCount()
        {
            Count += 1;
            WeakReferenceMessenger.Default.Send(new CountValueChangedMessage(Count));
        }
    }
}