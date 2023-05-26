namespace GettingStartedApp;

using System.Data.SqlClient;
using Dapper;
using GettingStartedApp.Entities;

public class Program {
    static void Main() {
        string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";

        using var connection = new SqlConnection(connectionString);

        connection.Open();

        if(false) {
            var users = connection.Query<User>(sql: "select top 2 * from Users");

            foreach (var user in users)
                Console.WriteLine(user);
        }

        if(false) {
            var user = connection.QueryFirstOrDefault<User>(sql: "select top 1 * from Users u where u.Age > 100");

            Console.WriteLine(user);
        }

        if(false) {
            int result = connection.Execute(sql:    @"update Products
                                                    set Price = Price + 10
                                                    where Id between 2010 and 2045");

            Console.WriteLine(result);
        }

        if (false) {
            int result = connection.ExecuteScalar<int>(sql: @"select max(u.Age) from Users u");

            Console.WriteLine(result);
        }
    }
}