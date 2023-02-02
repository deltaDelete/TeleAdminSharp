using System.Net.Http.Headers;
using TeleAdminSharp.Models;

namespace TeleAdminSharp; 

public class Van {
    public Van() {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("User-Agent", "TeleAdmin");
        var json = client.GetStringAsync("http://localhost/practice/hs/bot/getObj").Result;
        User[] users = Newtonsoft.Json.JsonConvert.DeserializeObject<User[]>(json);
        Console.WriteLine(users[0].Username);
    }
}