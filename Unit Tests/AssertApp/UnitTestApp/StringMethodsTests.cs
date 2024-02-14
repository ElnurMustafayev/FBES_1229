using ConsoleApp.Services;

namespace UnitTestApp;

public class StringMethodsTests
{
    [Theory]
    [InlineData("Bob", 3)]
    [InlineData("     ", 5)]
    [InlineData("", 0)]
    [InlineData("qwertyuiopfojhsjf!!!hvsbjfb273468712bekj", 40)]
    [InlineData(null, 0)]
    public void GetLength_SendString_ReturnsLength(string str, int expectedLength) {
        var actualLength = StringMethods.GetLength(str);
        Assert.Equal(expectedLength, actualLength);
    }

    // [Fact]
    // public void GetLength_SendString_ReturnsLength() {
    //     var str = "Bob";

    //     var length = StringMethods.GetLength(str);

    //     Assert.Equal(3, length);
    // }

    [Fact]
    public void GetLength_SendNull_ReturnsZero() {
        var length = StringMethods.GetLength(null);

        Assert.Equal(0, length);
    }
}