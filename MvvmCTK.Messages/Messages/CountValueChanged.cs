using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MvvmCTK.Messages.Messages
{
    public class CountValueChangedMessage : ValueChangedMessage<int>
    {
        public CountValueChangedMessage(int value) : base(value)
        {
        }
    }
}