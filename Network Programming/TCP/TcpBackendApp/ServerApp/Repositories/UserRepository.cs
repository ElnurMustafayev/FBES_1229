namespace ServerApp.Repositories;

using System.Data;
using System.Data.SqlClient;
using Dapper;

public class UserRepository {
    private const string connectionString = $"Server=localhost;Database=UsersDB;User Id=admin;Password=admin;";
    private readonly IDbConnection connection;

    public UserRepository() {
        this.connection = new SqlConnection(connectionString);
    }

    public async Task<bool> LoginAsync(string login, string password) {
        var success = await this.connection.ExecuteScalarAsync<int>(
            sql:    $@"select count(*)
                    from Users u
                    where u.Mail = @login and u.Password = @password",
            param: new { login, password }) > 0;

        return success;
    }

    public async Task RegisterAsync(string mail, string gender, string password) {
        await this.connection.ExecuteAsync(
            sql:    $@"insert into Users([Mail], [Gender], [Password])
                    values(@mail, @gender, @password)",
            param: new { mail, gender, password });
    }
}