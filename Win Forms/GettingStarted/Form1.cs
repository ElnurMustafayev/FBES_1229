using GettingStarted.Classes;

namespace GettingStarted {
    public partial class Form1 : Form {
        private const int max = 10;
        private const int min = 0;

        private int counter = 0;
        private int Counter {
            get { return counter; }
            set {
                if (value > max || value < min)
                    return;

                counter = value;
                this.CounterTextbox.Text = counter.ToString();

                this.PlusButton.Enabled = value != max;
                this.MinusButton.Enabled = value != min;
            }
        }

        public Form1() {
            InitializeComponent();
            this.Text = "Counter App";

            this.counter = ((max + min) / 2);
            this.CounterTextbox.Text = counter.ToString();

            //this.MyTextbox.BackColor = Color.FromArgb(200, 50, 50);
            //this.MyTextbox.Text = "Qwerty";
        }

        private void MyButton_Click(object sender, EventArgs e) {
            //var button = sender as Button;
            //counter++;
            //button.Text = counter.ToString();
            //this.MyTextbox.Text = sender.GetType().FullName;
        }

        private void PlusButton_Click(object sender, EventArgs e) {
            Counter++;
        }

        private void MinusButton_Click(object sender, EventArgs e) {
            Counter--;
            //new Test();
        }
    }
}