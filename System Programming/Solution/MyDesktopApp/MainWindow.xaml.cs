using MyClassLib.Models;
using MyClassLib.Repositories.Base;
using MyClassLib.Repositories;
using System.Windows;

namespace MyDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //User user = new User() {
            //    Login = "Elnur",
            //    Password = "Test12345",
            //};

            Dispatcher.Invoke(async () => {
                IUserRepository repository = new UserDapperRepository();
                var user = await repository.GetUserByLoginAsync("glacheze1c@hatena.ne.jp");
                this.MyTextBlock.Text = user.ToString();
            });
        }
    }
}
