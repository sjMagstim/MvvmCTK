using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using MvvmCTK.Messages.Messages;

namespace MvvmCTK.Messages.ViewModels
{
    public partial class CountViewModel : ObservableObject, IRecipient<CountValueChangedMessage>, IDisposable
    {
        [ObservableProperty] 
        private int _count;

        public CountViewModel()
        {
            // WeakReferenceMessenger.Default.Register(this);
            // StrongReferenceMessenger.Default.Register(this);
        }

        public void Receive(CountValueChangedMessage message)
        {
            Count = message.Value;
        }

        public void Dispose()
        {
            // StrongReferenceMessenger.Default.UnregisterAll(this);
        }
    }
}