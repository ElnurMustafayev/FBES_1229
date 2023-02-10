using ListBoxApp.Models;
using System.Windows.Forms;

namespace ListBoxApp
{
    public partial class Form1 : Form
    {
        //public List<User> Users { get; set; }

        public Form1() {
            InitializeComponent();

            this.UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            //this.Users = new List<User>();

            //var result = MessageBox.Show("Error message: 'something...'", "System error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User()
                {
                    Name = this.NameTextbox.Text,
                    Password = this.PasswordTextbox.Text,
                    ImageUrl = this.ImageUrlTextbox.Text,
                };

                //Users.Add(newUser);
                this.UsersListbox.Items.Add(newUser);
                //this.UsersListbox.DisplayMember = nameof(newUser.Name);

                messageLabel.ForeColor = Color.Green;
                messageLabel.Text = $"{newUser.Name} added in List successfully!";

                this.NameTextbox.Text = string.Empty;
                this.PasswordTextbox.Text = string.Empty;
                this.ImageUrlTextbox.Text = string.Empty;
                this.UserPictureBox.ImageLocation = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    text: ex.Message,
                    caption: ex.GetType().Name,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
        }

        private void ImageUrlTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)ConsoleKey.Enter) {
                this.UserPictureBox.ImageLocation = this.ImageUrlTextbox.Text;
            }
        }

        private void UsersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object currentItem = this.UsersListbox.SelectedItem;

            if (currentItem == null || currentItem is not User)
                return;

            var currentUser = currentItem as User;

            this.NameTextbox.Text = currentUser.Name;
            this.PasswordTextbox.Text = currentUser.Password;
            this.ImageUrlTextbox.Text = currentUser.ImageUrl;
            this.UserPictureBox.ImageLocation = this.ImageUrlTextbox.Text;
        }
    }
}