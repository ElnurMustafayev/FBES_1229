using System.Text.Json;

namespace UsersStorageApp {
    public partial class Form1 : Form {
        public List<User> Users { get; set; } = new List<User>();
        private BindingSource source = new BindingSource();

        public Form1() {
            InitializeComponent();

            // load
            var json = File.ReadAllText(User.filePath);
            this.Users = JsonSerializer.Deserialize<List<User>>(json);

            source.DataSource = this.Users;

            this.usersGrid.DataSource = source;
        }

        private void AddUserButton_Click(object sender, EventArgs e) {
            var addUserForm = new AddUserForm(this, this.Users, this.source);
            addUserForm.Show();
            this.Hide();
        }
    }
}