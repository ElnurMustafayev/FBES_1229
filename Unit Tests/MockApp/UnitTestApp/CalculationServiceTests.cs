namespace UnitTestApp;

using ConsoleApp.Services;
using ConsoleApp.Services.Base;
using Moq;

public class CalculationServiceTests
{
    [Theory]
    [InlineData(12, 2)]
    [InlineData(0, 1)]
    [InlineData(12345, 5)]
    [InlineData(-12345, 5)]
    public void Calculate_SetNum_GetSameNum(int num, int exceptedResult)
    {
        var positiveNum = Math.Abs(num);

        var numberServiceMock = new Mock<INumberService>();
        numberServiceMock.Setup((service) => service.GetNumberAsString(num))
            .Returns(positiveNum.ToString());

        // var userRepositoryMock = new Mock<IUserRepository>();
        // userRepositoryMock.Setup((repo) => repo.GetUserById(123))
        //     .Returns(new User() { ... });

        var service = new CalculationService(numberServiceMock.Object);

        var result = service.Calculate(num);

        Assert.Equal(exceptedResult, result);
    }
}