using System.Threading;
using System.Windows;

namespace DispatcherApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Timer timer = new Timer(
                callback: (state) => {
                    Dispatcher.Invoke(() => {
                        this.MyProgressBar.Value++;
                    });
                },
                state: null,
                dueTime: 0,
                period: 100
            );
        }
    }
}
