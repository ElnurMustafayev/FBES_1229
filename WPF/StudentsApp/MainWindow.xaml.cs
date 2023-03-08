using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace StudentsApp;

public partial class MainWindow : Window {
    public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
    public ObservableCollection<User> AllUsers { get; set; } = new ObservableCollection<User>();
    private List<Func<User, bool>> UsersFilters = new List<Func<User, bool>>();


    public MainWindow() {
        InitializeComponent();

        this.DataContext = this;

        foreach (var user in LoadUsers()) {
            AllUsers.Add(user);
            Users.Add(user);
        }

        // FILTERS
        UsersFilters.Add(u => u.Firstname.ToLower().Contains(this.UserInputTextBox.Text.ToLower()));
        UsersFilters.Add(u => u.IsMarried == this.IsMarriedCheckBox.IsChecked);
        UsersFilters.Add(u =>
        {
            if ((bool)this.MaleRadioButton.IsChecked)
                return u.Gender == Gender.Male;
            else if ((bool)this.FemaleRadioButton.IsChecked)
                return u.Gender == Gender.Female;
            else
                return true;
        });

        UsersFilters.Add(u =>
        {
            var birthDate = DateTime.Parse(u.BirthDate);

            var age = DateTime.Now.Year - birthDate.Year;
            if (birthDate.Date > DateTime.Now.AddYears(-age)) 
                age--;

            bool isAdult = age >= 18;

            return (bool)this.IsAdultCheckBox.IsChecked == isAdult;
        });

        FilterBy(UsersFilters);


        //Func<int, bool> check1 = num =>
        //{
        //    Console.WriteLine("Check1");
        //    return num > 10;
        //};

        //check1 += num =>
        //{
        //    Console.WriteLine("Check2");
        //    return num % 2 == 0;
        //};

        //var result = check1.Invoke(15);
        //Console.WriteLine(result);

        //IEnumerable<int> nums = new int[]
        //{
        //    123,12,45,10,5,23,3
        //};

        //var founds = nums.Where(check1);
        //
        //foreach (int item in founds)
        //{
        //    Console.WriteLine(item);
        //}
    }

    private IEnumerable<User> LoadUsers() {
        var json = File.ReadAllText(@".\Assets\Users.json");
        var users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

        if (users == null || users.Any() == false)
            return Enumerable.Empty<User>();
        else
            return users;
    }


    private void FilterBy(IEnumerable<Func<User, bool>> filters) 
    {
        this.Users.Clear();

        var founds = this.AllUsers.Where(u => filters.All(p => p.Invoke(u)));

        foreach (var found in founds)
        {
            this.Users.Add(found);
        }
    }

    // FIRSTNAME
    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
        FilterBy(UsersFilters);
    }

    // IS MARRIED
    private void IsMarriedCheckBox_Checked(object sender, RoutedEventArgs e)
    {
        FilterBy(UsersFilters);
    }

    private void IsMarriedCheckBox_Unchecked(object sender, RoutedEventArgs e)
    {
        FilterBy(UsersFilters);
    }

    // IS ADULT
    private void IsAdultCheckBox_Checked(object sender, RoutedEventArgs e)
    {
        FilterBy(UsersFilters);
    }
    private void IsAdultCheckBox_Unchecked(object sender, RoutedEventArgs e)
    {
        FilterBy(UsersFilters);
    }

    // GENDER
    private void GenderRadiobuttonChecked(object sender, RoutedEventArgs e)
    {
        FilterBy(UsersFilters);
    }
}