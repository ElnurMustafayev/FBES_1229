using System.Text.Json.Serialization;

namespace RoutingApp.Models;

public class User
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }
}