using System.Net.Http.Headers;
using System.Text;
using TeleAdminSharp.Models;

namespace TeleAdminSharp; 

public class Van {
    public Van() {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("User-Agent", "TeleAdmin");
        var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/practice/hs/bot/getObj") {
            Content = new StringContent("Bebra", Encoding.UTF8, "application/json")
        };
        var response = client
            .SendAsync(request).Result;
        //var response = client.GetAsync("http://localhost/practice/hs/bot/getObj", new StringContent("Bebra", Encoding.UTF8, "application/json")).Result;
        var json = response.Content.ReadAsStringAsync().Result;
        User[] users = Newtonsoft.Json.JsonConvert.DeserializeObject<User[]>(json);
        Console.WriteLine(users[0].Username);
    }
}