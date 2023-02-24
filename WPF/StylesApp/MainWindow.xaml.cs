using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StylesApp {
    public partial class MainWindow : Window, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private Brush counterColor = Brushes.Black;

        public Brush CounterColor { 
            get => counterColor;
            set => ChangeProperty(out this.counterColor, value);
        }

        public void ChangeProperty<T>(out T field, T value, [CallerMemberName] string propName = "") {
            field = value;
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private ObservableCollection<User> users = new ObservableCollection<User>();

        public ObservableCollection<User> Users {
            get { return users; }
            set { users = value; }
        }




        public MainWindow() {
            InitializeComponent();

            this.DataContext = this;

            this.Users.Add(new User("David", "Kashirskiy", 15));
            this.Users.Add(new User("Diana", "Ahadova", 16));
            this.Users.Add(new User("Samra", "Mamedli", 17));
        }



        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            //var isOnLimit = this.MyTextBox.Text.Length >= 10;
            //
            //this.CounterColor = isOnLimit ? Brushes.Red : Brushes.Black;
            //
            //if(isOnLimit) {
            //    this.MyTextBox.IsEnabled = false;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var newUser = new User(
                name: Guid.NewGuid().ToString("N")[..6],
                surname: Guid.NewGuid().ToString("N")[..6],
                age: new Random().Next(60));

            this.Users.Add(newUser);

            //MessageBox.Show($"User added. Count: {this.Users.Count}");
        }
    }
}
