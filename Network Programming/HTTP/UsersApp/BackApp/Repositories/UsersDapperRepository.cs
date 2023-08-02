using System.Data.SqlClient;
using System.Data;
using Shared.Models;
using Dapper;

namespace BackApp.Repositories;

public class UsersDapperRepository {

    private readonly IDbConnection connection;

    public UsersDapperRepository(string connectionString) {
        this.connection = new SqlConnection(connectionString);
    }

    public async Task<IEnumerable<User>> FindAllAsync() {
        var users = await this.connection.QueryAsync<User>($@"select * from Users");

        return users;
    }

    public async Task<User> FindAsync(int id) {
        var user = await this.connection.QueryFirstAsync<User>(
            sql:    $@"select * from Users u
                    where u.Id = @id",
            param: new { id });

        return user;
    }

    public async Task CreateAsync(User user) {
        await this.connection.ExecuteAsync(
            sql: @"insert into Users([Name], [Surname])
                    values(@name, @surname)",
            param: new { user.name, user.surname });
    }
}