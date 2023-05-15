namespace GettingStarted;

using System.Data.SqlClient;

public class Program {
    static void Main() {
        // 1. Install Client nuget-package: dotnet add package System.Data.SqlClient
        // 2. using System.Data.SqlClient;
        // 3. Init & Open connection with ConnectionString
        // 4. Create & Execute SqlCommand

        string serverAddress = "localhost";
        string databaseName = "TestDb";
        string login = "admin";
        string password = "adminnn";

        string connectionString = $"Server={serverAddress};Database={databaseName};User Id={login};Password={password};";

        try {
            using var connection = new SqlConnection(connectionString);

            connection.Open();

            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "select count(*) from Users";

            var result = sqlCommand.ExecuteScalar();

            Console.WriteLine(result);
            //connection.Dispose();
        }
        catch (SqlException ex) {
            Console.WriteLine("SQL EXCEPTION:");
            foreach (var error in ex.Errors) {
                Console.WriteLine($"Error: {error}\n");
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }
    }
}