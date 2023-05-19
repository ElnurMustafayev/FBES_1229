using AdoNetInWpfApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AdoNetInWpfApp.Repositories;

public class ProductSqlRepository {
    private const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
    private readonly SqlConnection sqlConnection;

    public ProductSqlRepository() {
        this.sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
    }

    public IEnumerable<Product> Find(string? name, decimal? price) {
        if (string.IsNullOrEmpty(name))
            return Enumerable.Empty<Product>();

        string query =  @"select Id, Name, Price 
                        from Products p 
                        where p.Name like @name";

        using SqlCommand command = new SqlCommand();
        command.Connection = this.sqlConnection;

        command.Parameters.Add(new SqlParameter("name", name));

        if (price != null) {
            query += " and p.Price between @priceStart and @priceEnd";
            command.Parameters.Add(new SqlParameter("priceStart", price - 100));
            command.Parameters.Add(new SqlParameter("priceEnd", price + 100));
        }

        command.CommandText = query;

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
}