using RelationsApp;
using RelationsApp.Entities;
using RelationsApp.Entities.OneToOne;
using RelationsApp.Entities.OneToMany;

MyDbContext context = new MyDbContext();


var post = context.Posts.First();

var postComments = context.Comments.Where(c => c.PostId == 1).ToList();

foreach (var comment in postComments) {
    Console.WriteLine($"{comment.Id}: {comment.Text}");
}


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