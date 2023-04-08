using FlyweightApp.Services;
using System.Runtime.Caching;

namespace FlyweightApp {
    class Program {
        static void Main() {
            var cache = new MemoryCache("my_cache");
            CountryService countryService = new CountryService(cache);
            var country = countryService.Get("AZ");

            Console.WriteLine(country);

            #region MemoryCache

            //MemoryCache cache = new MemoryCache("my_cache");

            //var item = new CacheItem(key: "key", "something");
            //var policy = new CacheItemPolicy() {
            //    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(3),
            //    RemovedCallback = (arg) => {
            //        Console.WriteLine($"Cache element with key '{arg.CacheItem.Key}' was auto-removed"); 
            //    }
            //};

            //cache.Add(item, policy);
            ////cache.Add("1", "one", policy);
            ////cache.Add("2", "two", policy);
            ////cache.Add("3", "three", policy);

            //while(cache.Get(key: "key") != null) {

            //}

            #endregion
        }
    }
}