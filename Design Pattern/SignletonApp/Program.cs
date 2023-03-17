using System.Text.Json;

namespace SignletonApp;

class Program {
    static void Main() {
        SettingsSingleton settings1 = SettingsSingleton.GetInstance();
        SettingsSingleton settings2 = SettingsSingleton.GetInstance();

        Console.WriteLine(settings1.Settings.AdultYear);
        Console.WriteLine(settings2.Settings.AdultYear);
    }
}
