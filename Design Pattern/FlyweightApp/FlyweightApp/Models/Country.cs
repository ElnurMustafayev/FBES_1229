using System.Text.Json.Serialization;

namespace FlyweightApp.Models
{
    public class Country
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        public override string ToString() => $@"{Code}: {Name}";
    }
}