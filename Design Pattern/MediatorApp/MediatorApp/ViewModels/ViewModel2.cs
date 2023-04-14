using MediatorApp.Messages.Base;

namespace MediatorApp.ViewModels;

public class ViewModel2 : ViewModelBase {
    private User user;
    public string UserName { get; set; } = "Unknown";
    public string UserSurname { get; set; } = "Unknown";

    public ViewModel2(Messenger messenger) : base(messenger) {
        messenger.Subscribe<AfterSuccessLoginMessage>((obj) => {
            if (obj is AfterSuccessLoginMessage message) {
                Console.WriteLine($"ViewModel2 received the '{nameof(AfterSuccessLoginMessage)}' message!");

                user = message.User;
            }
        });
    }
}