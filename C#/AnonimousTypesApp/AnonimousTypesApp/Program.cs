// from another project
//var repository = new StudentRepository(connectionString);
//var result = repository.Get(150, 170).ToList();


//var item = new { result };





var item1 = new
{
    test = "one"
};

var item2 = new
{
    testtttererwer = "one",
    qfqf = "one",
    testtttwqfwqfererwer = "one",
};

Console.WriteLine(item1.GetType().FullName);
Console.WriteLine(item2.GetType().FullName);



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