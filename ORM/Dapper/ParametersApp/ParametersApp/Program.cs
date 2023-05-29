using System.Data.SqlClient;
using Dapper;
using ParametersApp.Entities;
using ParametersApp.QueryParams;
using ParametersApp.Repositories;

string connectionString = $"Server=localhost;Database=Academy;User Id=admin;Password=admin;";

var repository = new StudentRepository(connectionString);

//var result = repository.Get(150, 170).ToList();

//result.ForEach(student => Console.WriteLine(student));







//var student = repository.Get(777);

//Console.WriteLine(student?.Name ?? "Unknown");

//var item = new { student };




//var item1 = new
//{
//    test = "one"
//};

//var item2 = new
//{
//    testtttererwer = "one",
//    qfqf = "one",
//    testtttwqfwqfererwer = "one",
//};

//Console.WriteLine(item1.GetType().FullName);
//Console.WriteLine(item2.GetType().FullName);



//var result = allStudents.Select(student => new
//{
//    Firstname = student.Name,
//    Lastname = student.Surname,
//})
//    .Select(obj => obj.Firstname);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}






//foreach (var student in allStudents)
//{
//    Console.WriteLine(student);
//}






//using var connection = new SqlConnection(connectionString);

//connection.Open();

//var queryParams = new QueryWithId(id: 777);

//var student = connection.QueryFirstOrDefault<Student>
//    (sql: $@"select * from Students where Id = @Id",
//    param: queryParams);

//Console.WriteLine(student);