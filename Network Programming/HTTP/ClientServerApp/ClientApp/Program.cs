using ClientApp.Models;
using System.Net;
using System.Text.Json;

if (true) {
    HttpWebRequest request = WebRequest.CreateHttp("https://pogoapi.net/api/v1/pokemon_stats.json");

    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

    Stream responseStream = response.GetResponseStream();
    using (StreamReader reader = new StreamReader(responseStream)) {
        var responseJson = await reader.ReadToEndAsync();
        var pokemonStats = JsonSerializer.Deserialize<IEnumerable<PokemonStat>>(responseJson);

        Console.WriteLine($"Max attack: {pokemonStats.Max(stat => stat.base_attack)}");

        foreach (var pokemonStat in pokemonStats) {
            Console.WriteLine(pokemonStat.base_attack);
        }
    }
}




if (false) {
    WebClient webClient = new WebClient();

    //string result = webClient.DownloadString("https://google.com");
    string result = webClient.DownloadString("https://www.google.com/search?q=http+protocol");
    Console.WriteLine(result);

    File.WriteAllText("google.html", result);
}