using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

namespace BindingApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private string textboxText;

        public string TextboxText {
            get => textboxText;
            set { 
                textboxText = value;
                PropertyChanged.Invoke(sender: this, new PropertyChangedEventArgs(nameof(TextboxText)));
            }
        }

        public string ButtonColor { get; set; } = "Red";

        public MainWindow() {
            InitializeComponent();

            this.DataContext = this;

            //this.textBox.Text = "test";
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.TextboxText = Guid.NewGuid().ToString();

            //Console.WriteLine($"Component: {this.textBox.Text}");
            //Console.WriteLine($"Property:  {this.TextboxText}");
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            // [44, 69]
            this.TextboxText += (char)(e.Key + 21);
        }
    }
}
