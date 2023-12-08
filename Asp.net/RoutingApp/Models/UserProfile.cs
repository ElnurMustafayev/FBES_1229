using System.Text.Json.Serialization;

namespace RoutingApp.Models;

public class UserProfile
{
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Firstname { get; set; }
    [JsonPropertyName("surname")]
    public string? Lastname { get; set; }
    [JsonPropertyName("photo")]
    public string? AvatarUrl { get; set; }

    // TODO: caseinsensitive
    public string? Position { get; set; }
    public IEnumerable<string>? Skills { get; set; }
    public string? Description { get; set; }
}

