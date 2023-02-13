using Microsoft.VisualBasic.ApplicationServices;

namespace UsersStorageApp {
    public partial class AddUserForm : Form {
        private Form parentForm;
        private List<User> users;
        private BindingSource source;

        public AddUserForm(Form parentForm, List<User> users, BindingSource source) {
            InitializeComponent();

            this.parentForm = parentForm;
            this.users = users;
            this.source = source;
        }

        private void CloseForm(object sender, EventArgs e) {
            /*
             
            9e836687-6fef-4804-94e6-46aaa1f53939	dasd	sdasdasd
            68fe2009-c949-4b1a-a5b2-9c7c058922d2	Bob	Bobovich
            2ed80509-c1d6-471f-89b5-8a1127176c6f	Maria	Carey
             
             */



            this.parentForm.Show();

            this.Close();
        }

        protected override void OnClosed(EventArgs e) {
            this.parentForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            var newUser = new User() {
                Name = this.NameTextbox.Text,
                Surname = this.SurnameTextbox.Text,
            };

            users.Add(newUser);

            source.ResetBindings(false);

            //Console.WriteLine($"New User added! '{newUser}'");

            this.CloseForm(sender, e);
        }
    }
}
