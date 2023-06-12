using RelationsApp;
using RelationsApp.Entities;
using RelationsApp.Entities.OneToOne;
using RelationsApp.Entities.OneToMany;
using RelationsApp.Entities.ManyToMany;

MyDbContext context = new MyDbContext();


//int[] nums = { 1, 2, 3, 4 };

//var result = from num in nums
//             where num > 3
//             select num;





var query = from country in context.Countries
            join city in context.Cities on country.CityId equals city.Id
            //where country.Name.Contains("jan")
            select new {Country = country.Name, City = city.Name};

var result = query.ToList();

foreach (var item in result) {
    Console.WriteLine(item);
}








//var query = context.Countries
//    .Join(inner: context.Cities,
//    outerKeySelector: country => country.CityId,
//    innerKeySelector: city => city.Id,
//    resultSelector: (country, city) => new { Country = country, City = city })
//    .Where(cc => cc.Country.Id < 10 || cc.City.Id < 10)
//    .Select(cc => new { Country = cc.Country.Name, City = cc.City.Name });

//foreach (var item in query) {
//    Console.WriteLine(item);
//}







//var query = context.Users
//    .Take(10)
//    .OrderBy(u => u.Name)
//    .GroupBy(u => u.Name);

//foreach (var item in query) {
//    Console.WriteLine($"KEY: {item.Key}");

//    foreach (var element in item) {
//        Console.WriteLine($"\t{element}");
//    }
//}









//var query = context.Users
//    .Take(10)
//    .OrderBy(u => u.Name)
//    .GroupBy(u => u.Name)
//    .ToList();

//foreach (var item in query) {
//    Console.WriteLine($"KEY: {item.Key}");

//    foreach (var element in item) {
//        Console.WriteLine($"\t{element}");
//    }
//}










//var user1 = new User("Diana");
//var user2 = new User("Samra");
//var user3 = new User("Arkun");
//var user4 = new User("Tamerlan");
//var user5 = new User("Tima");
//var user6 = new User("Elnur");


//var chat1 = new Chat("FBES_1229") {
//    Users = new List<User>() {
//        user1, user2, user3, user4, user5, user6,
//    },
//};

//var chat2 = new Chat("BFFs 4ever") {
//    Users = new List<User>() {
//        user3, user4, user5
//    },
//};

//context.Chats.AddRange(chat1, chat2);
//context.SaveChanges();













//var post = context.Posts.First();

//var postComments = context.Comments.Where(c => c.PostId == 1).ToList();

//foreach (var comment in postComments) {
//    Console.WriteLine($"{comment.Id}: {comment.Text}");
//}


//var post = new Post() {
//    Title = "Header",
//    Text = "Something...",
//    Comments = new List<Comment>() {
//        new Comment("ahaha"),
//        new Comment("lol"),
//        new Comment("interesting"),
//        new Comment("bob"),
//    },
//};

//context.Posts.Add(post);
//context.SaveChanges();





// ONE TO ONE
//context.Countries.Select(country => new { country.Id, country.CityId }).ToList();
//context.Countries.Select(country => new Country { Id = country.Id, Name = country.Name }).ToList();

//var city = new City {
//    Id = 1,
//};
//context.Cities.Remove(city);
//context.SaveChanges();




//var country = context.Countries.First();
//context.Countries.Remove(country);

//context.SaveChanges();



//int? maxCityId = context.Countries.Max(country => country.CityId);
//Console.WriteLine(maxCityId);

//var result = context.Countries.Max(country => country.CityId) == context.Cities.Max(city => city.Id);
//Console.WriteLine(result);



//var city = new City() {
//    Name = "Moscow"
//};

//var country = new Country() {
//    Name = "Russia",
//    City = city
//};

//context.Countries.Add(country);
//context.SaveChanges();




//var country = context.Countries.First((country) => country.Name.StartsWith("Azer"));

//var city = context.Cities.First((city) => city.Name.Contains("baku"));


//country.CityId = city.Id;
//context.Countries.Update(country);
//context.SaveChanges();




//Console.WriteLine(country.Name);
//Console.WriteLine(city.Name);




//var city = new City() {
//    Name = "Baku"
//};
//context.Cities.Add(city);
//context.SaveChanges();



//context.Add(country);
//context.SaveChanges();

//var country = new Country() {
//    Name = "Azerbaijan",
//};

//context.Add(country);
//context.SaveChanges();