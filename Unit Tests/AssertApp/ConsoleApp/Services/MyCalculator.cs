namespace ConsoleApp.Services;

public class MyCalculator
{
    public double Sum(double num1, double num2) {
        var result = num1 + num2;

        return result;
    }

    public int Sum(int num1, int num2) {
        int result = 0;
        
        checked
        {
            result = num1 + num2;
        }

        return result;
    }

    public int Div(int num1, int num2) {
        if(num2 == 0) {
            throw new ArgumentException(
                message: "The second operand can not be zero",
                paramName: nameof(num2));
        }

        return num1 / num2;
    }
}