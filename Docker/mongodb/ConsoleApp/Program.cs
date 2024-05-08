using MongoDB.Driver;

var mongoDbConnectionoString = "mongodb://localhost:27017";
var client = new MongoClient(mongoDbConnectionoString);

var productsDb = client.GetDatabase("ProductsDb");
await productsDb.CreateCollectionAsync("Products");

var collection = productsDb.GetCollection<object>("Products");

await collection.InsertOneAsync(new { Name = "Bob" });