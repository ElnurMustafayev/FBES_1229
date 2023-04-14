using MediatorApp.Messages.Base;
using System.Xml.Linq;

namespace MediatorApp.ViewModels;

public class AuthViewModel : ViewModelBase {
	public AuthViewModel(Messenger messenger) : base(messenger) { }

	public void Login(string login, string password) {
        if(login == "admin" && password == "admin") {
            var message = new AfterSuccessLoginMessage() {
                Login = login,
                Password = password,
                User = new User() {
                    Name = "Elnur",
                    Surname = "Mustafayev",
                }
            };

            messenger.Send(message);
        }
    }
}