using MediatorApp.Messages.Base;

namespace MediatorApp.ViewModels;

public class ViewModel1 : ViewModelBase {
    private User user;
    public ViewModel1(Messenger messenger) : base(messenger) {
        messenger.Subscribe<AfterSuccessLoginMessage>((obj) => {
            if (obj is AfterSuccessLoginMessage message) {
                Console.WriteLine($"ViewModel1 received the '{nameof(AfterSuccessLoginMessage)}' message!");

                user = message.User;
            }
        });
    }
}