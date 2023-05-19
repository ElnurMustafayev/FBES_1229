namespace WithParameters2App;

using System.Data;
using System.Data.SqlClient;

internal class Program {
    static void Main() {
        //var productPrice = Console.ReadLine();
        var nameFilter = Console.ReadLine();

        const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";

        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();

        //if (productPrice.Contains("drop") || productPrice.Contains("truncate") || productPrice.Contains("delete"))
        //    throw new InvalidOperationException("SQL INJECTION!!!");

        //string getCountQuery = @$"select count(*) from Products p where p.Name like '{nameFilter}'";
        string getCountQuery = @$"select count(*) from Products p where p.Name like @nameFilter";

        using SqlCommand command = new SqlCommand(
            connection: sqlConnection,
            cmdText: getCountQuery);

        var nameFilterParameter = new SqlParameter(parameterName: "nameFilter", nameFilter);
        command.Parameters.Add(nameFilterParameter);

        //command.Parameters.Add(new SqlParameter(parameterName: "Price", productPrice));

        var result = command.ExecuteScalar();

        Console.WriteLine($"Result: {result}");
    }
}