namespace ParametersApp.Repositories;

using System.Data;
using System.Data.SqlClient;
using Dapper;
using ParametersApp.Entities;
using ParametersApp.QueryParams;

public class StudentRepository
{
    private readonly IDbConnection connection;

	public StudentRepository(string connectionString) {
        this.connection = new SqlConnection(connectionString);
    }

    public Student? Get(int id) {
        //var queryParams = new QueryWithId(id);

        var student = this.connection.QueryFirstOrDefault<Student>(
            sql: $@"select * from Students where Id = @Id",
            param: new { id });

        return student;
    }


    public IEnumerable<Student> Get(int startId, int endId)
    {
        var student = this.connection.Query<Student>(
            sql: $@"select * from Students where Id between @startId and @endId",
            param: new { startId, endId });

        return student;
    }


    public IEnumerable<Student> Get() => this.connection.Query<Student>(sql: $@"select * from Students");
}