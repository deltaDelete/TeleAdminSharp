using Newtonsoft.Json;

namespace TeleAdminSharp.Models; 

[JsonObject]
public class User {
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("username")]
    public string Username { get; set; }
    [JsonProperty("is-bot")]
    public bool IsBot { get; set; }
}