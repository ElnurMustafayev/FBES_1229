namespace MyClassLib.Repositories;

using MyClassLib.Models;
using MyClassLib.Repositories.Base;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

public class UserDapperRepository : IUserRepository {
    public async Task<User> GetUserByLoginAsync(string login) {
        string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
        var connection = new SqlConnection(connectionString);
        
        User found = await connection.QueryFirstAsync<User>(
            sql: "select top 1 * from Users u where u.Login = @login",
            param: new { login });

        return found;
    }
}