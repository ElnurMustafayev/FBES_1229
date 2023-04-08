using FlyweightApp.Models;
using System.Runtime.Caching;
using System.Text.Json;

namespace FlyweightApp.Services
{
    public class CountryService {
        private readonly ObjectCache cache;

        public CountryService(ObjectCache cache) {
            this.cache = cache;
        }

        public Country? Get(string countryCode) {
            // normalization
            countryCode = countryCode.Trim().ToUpper();

            // search in cache
            var resultFromCache = this.cache.Get(countryCode);
            if (resultFromCache != null) {
                return resultFromCache as Country;
            }

            // if not found in cache: search in storage
            var json = File.ReadAllText("countries.json");
            var countries = JsonSerializer.Deserialize<IEnumerable<Country>>(json);

            // add in cache
            var resultFromJson = countries?.FirstOrDefault(c => c.Code == countryCode);
            this.cache.Add(
                key: countryCode, 
                value: resultFromJson, 
                policy: new CacheItemPolicy() {
                    AbsoluteExpiration = DateTimeOffset.Now.AddHours(1),
                });

            return resultFromJson;
        }
    }
}
