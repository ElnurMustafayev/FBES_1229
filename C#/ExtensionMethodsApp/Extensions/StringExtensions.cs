namespace ExtensionMethodsApp.Extensions;

public static class StringExtensions {
    public static bool NeedToTrim(this string str, char symbol = ' ') {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        return str.Trim(symbol) != str;
    }
}