using Npgsql;

var host = "akshambazari.postgres.database.azure.com";
var login = "akhshambazari";
var password = "Bazar12345!";
var database = "postgres";
var port = 5432;

var connectionString = $"User ID={login};Password={password};Host={host};Port={port};Database={database};";

using var connection = new NpgsqlConnection(connectionString);
await connection.OpenAsync();


for (int i = 0; i < 100; i++)
{
    using var command = new NpgsqlCommand($"create table TEST{Guid.NewGuid().ToString("N").ToUpper()} ( myColumn varchar(100) )", connection);

    var result = await command.ExecuteScalarAsync();
}