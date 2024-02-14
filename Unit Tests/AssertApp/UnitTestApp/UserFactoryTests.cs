#pragma warning disable CS8625

using ConsoleApp.Services;

namespace UnitTestApp;

public class UserFactoryTests
{
    private const int correctUserAge = 17;
    private const string correctUsername = "Bob";

    // 1. На самом ли деле при отправлении {age} в итоге у результирующего юзера возраст {age}
    [Fact]
    public void Create_SetCorrectAge_ReturnsUserWithSameAge() {
        var user = UserFactory.Create(correctUsername, correctUserAge);

        //Assert.True(user.Age == correctUserAge);
        Assert.Equal(user.Age, correctUserAge);
    }

    // 2. На самом ли деле при отправлении в метод Create username, который равен null выкидывается ArgumentNullException
    [Fact]
    public void Create_SetNullName_ThrowsArgumentNullException() {
        // try {
        //     var user = UserFactory.Create(username: null, correctUserAge);
        // }
        // catch(Exception ex) {
        //     Assert.True(ex is ArgumentNullException);
        // }
        
        Assert.Throws<ArgumentNullException>(
            () => UserFactory.Create(username: null, correctUserAge));
    }

    // 3. На самом ли деле при отправлении в метод Create age, который равен -1 выкидывается ArgumentOutOfRangeException
    [Fact]
    public void Create_SetNegativeAge_ThrowsArgumentOutOfRangeException() {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => UserFactory.Create(correctUsername, age: -1));
    }

    // 4. На самом ли деле значение {username} trim-ится
    [Theory]
    [InlineData("  BOb   ", "BOb")]
    [InlineData("bo b", "bo b")]
    //[InlineData(null, null)]
    public void Create_SetUsernameWithSpacesInStartAndEnd_ReturnsUserWithTrimedUsername(string usernameWithSpaces, string expectedUsername) {
        var user = UserFactory.Create(usernameWithSpaces, correctUserAge);

        Assert.Equal(expectedUsername, user.Username);
    }
}