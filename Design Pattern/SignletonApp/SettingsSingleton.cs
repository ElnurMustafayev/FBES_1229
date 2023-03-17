using System.Text.Json;

namespace SignletonApp;

public sealed class SettingsSingleton {
    public readonly Settings? Settings;

    private static SettingsSingleton? instance = null;

    public static SettingsSingleton GetInstance() {
        if (instance == null) {
            // Settings initialization
            var json = File.ReadAllText("settings.json");
            var settings = JsonSerializer.Deserialize<Settings>(json);

            instance = new SettingsSingleton(settings);
        }

        return instance;
    }

    private SettingsSingleton(Settings? settings) => Settings = settings;
}