namespace WithParametersApp.Repositories;

using System.Data.SqlClient;
using WithParametersApp.Models;

public class ProductsRepository {
    private const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
    private readonly SqlConnection sqlConnection;

    public ProductsRepository() {
        this.sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
    }

    public IEnumerable<Product> GetAll() {
        string getAllProductsQuery = @"select * from Products p";

        using SqlCommand command = new SqlCommand(
            connection: sqlConnection,
            cmdText: getAllProductsQuery);

        using SqlDataReader reader = command.ExecuteReader();

        var products = new List<Product>();
        while (reader.Read()) {
            var product = new Product() {
                Id = reader.GetInt32(0),
                Name = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1),
                Price = reader.IsDBNull(2) ? null : reader.GetDecimal(2),
            };

            products.Add(product);
        }

        return products;
    }

    public bool Add(Product newProduct) {
        string insertProductQuery = @$"insert into Products([Name], [Price])
                                        values('{newProduct.Name}', {newProduct.Price})";

        using SqlCommand command = new SqlCommand(
            connection: sqlConnection,
            cmdText: insertProductQuery);

        int affectedRowsCount = command.ExecuteNonQuery();

        return affectedRowsCount > 0;
    }
}