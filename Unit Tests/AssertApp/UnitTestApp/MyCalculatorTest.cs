namespace UnitTestApp;

using ConsoleApp.Services;

public class MyCalculatorTest
{
    [Fact]
    public void Sum()
    {
        var calculator = new MyCalculator();

        var result = calculator.Sum(5, 5);

        Assert.Equal(10, result);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(-1,-1,-2)]
    [InlineData(0,0,0)]
    public void Sum_SetOperands_GetSum(int num1, int num2, int expectedResult)
    {
        var calculator = new MyCalculator();

        var result = calculator.Sum(num1, num2);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Div_PutSecondOperandZero_ThrowsArgumentException() {
        var calculator = new MyCalculator();

        Assert.Throws<ArgumentException>(() => calculator.Div(100, 0));
    }
}