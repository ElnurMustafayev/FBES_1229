using StackExchange.Redis;

var redisConnection = ConnectionMultiplexer.Connect("localhost");

/*
var redisChannel = new RedisChannel("MyChannel", PatternMode.Auto);

var subscriber = redisConnection.GetSubscriber();
await subscriber.SubscribeAsync(redisChannel, (channel, redisValue) => {
    System.Console.WriteLine($"Subscriber: '{redisValue}'");
});

await subscriber.PublishAsync(redisChannel, "value");

Console.ReadKey();
*/

var database = redisConnection.GetDatabase(3);
await database.StringSetAsync("arkhun", "krutoy");

var valueLength = await database.StringAppendAsync("samra", "qwerty");
System.Console.WriteLine(valueLength);

string? redisValue = database.StringGet("mykey");
System.Console.WriteLine(redisValue);