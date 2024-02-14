namespace ConsoleApp.Services;

using ConsoleApp.Services.Base;

public class MyNumberService : INumberService
{
    public string GetNumberAsString(int num) {
        return Math.Abs(num).ToString();
    }
}