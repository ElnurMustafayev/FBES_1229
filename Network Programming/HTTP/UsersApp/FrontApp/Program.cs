using Shared.Models;
using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();

User newUser = new User() {
    name = Console.ReadLine(),
    surname = Console.ReadLine(),
};

HttpContent jsonContent = JsonContent.Create(newUser);
HttpResponseMessage response = await httpClient.PostAsync("http://localhost/users/create", jsonContent);

using var reader = new StreamReader(response.Content.ReadAsStream());
var responseTxt = await reader.ReadToEndAsync();
Console.WriteLine(response.StatusCode);
Console.WriteLine(responseTxt);
