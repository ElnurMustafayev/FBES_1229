using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
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

namespace StudentsApp;

public partial class MainWindow : Window {
    public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
    public ObservableCollection<User> AllUsers { get; set; } = new ObservableCollection<User>();


    public MainWindow() {
        InitializeComponent();

        this.DataContext = this;

        foreach (var user in LoadUsers()) {
            Users.Add(user);
            AllUsers.Add(user);
        }
    }

    private IEnumerable<User> LoadUsers() {
        var json = File.ReadAllText(@".\Assets\Users.json");
        var users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

        if (users == null || users.Any() == false)
            return Enumerable.Empty<User>();
        else
            return users;
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var founds = this.AllUsers.Where(u => u.Firstname.ToLower().Contains(this.UserInputTextBox.Text.ToLower()));

        this.Users.Clear();

        foreach (var found in founds) {
            this.Users.Add(found);
        }
    }
}