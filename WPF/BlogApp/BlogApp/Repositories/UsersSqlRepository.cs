namespace BlogApp.Repositories;

using System;
using System.Data.SqlClient;
using BlogApp.Entities;
using BlogApp.Repositories.Base;
using Dapper;

public class UsersSqlRepository : IUsersRepository<User>
{
    private const string connectionString = "Server=localhost;Database=BlogApp;User Id=admin;Password=admin;";
    private SqlConnection connection;

    public UsersSqlRepository()
	{
        this.connection = new SqlConnection(connectionString);
    }

    public User Login(string login, string password)
	{
        ArgumentNullException.ThrowIfNull(login, nameof(login));
        ArgumentNullException.ThrowIfNull(password, nameof(password));

        var query = "exec LoginUser @login, @password";
        var user = this.connection.QueryFirst<User>(sql: query, new { login, password });

        return user;
    }
}