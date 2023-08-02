using BackApp.Repositories;
using Shared.Models;
using System.Net;
using System.Text.Json;

HttpListener httpListener = new HttpListener();

const int port = 80;

httpListener.Prefixes.Add($"http://*:{port}/");

httpListener.Start();

const string connectionString = "Data Source=.;Initial Catalog=UsersDb;Integrated Security=True";
var usersRepository = new UsersDapperRepository(connectionString);

while(true) {
    HttpListenerContext context = await httpListener.GetContextAsync();

    //ThreadPool.QueueUserWorkItem(async (state) => {
    string requestPath = context.Request.Url?.AbsolutePath!;

    var requestPathItems = requestPath.Split('/', StringSplitOptions.RemoveEmptyEntries)
        .Take(2);

    string responseJson = string.Empty;

    switch(requestPathItems.First().ToLower()) {
        case "users": {
                switch(requestPathItems.Last().ToLower()) {
                    case "getall":
                        if(context.Request.HttpMethod.ToLower() == "get") {
                            var allUsers = await usersRepository.FindAllAsync();
                            responseJson = JsonSerializer.Serialize(allUsers);

                            context.Response.ContentType = "application/json";
                            context.Response.StatusCode = 200;
                        }
                        else {
                            responseJson = "Error: Invalid method type!";
                            context.Response.ContentType = "plain/text";
                            context.Response.StatusCode = 400;
                        }
                        break;

                    case "create":
                        if(context.Request.HttpMethod.ToLower() == "post") {
                            using var reader = new StreamReader(context.Request.InputStream);
                            var requestJson = await reader.ReadToEndAsync();
                            var user = JsonSerializer.Deserialize<User>(requestJson);

                            if(user == null) {
                                context.Response.StatusCode = 400;
                                break;
                            }

                            await usersRepository.CreateAsync(user);
                            context.Response.StatusCode = 201;
                            responseJson = $"User '{user.name} {user.surname}' created successfully!";
                            context.Response.ContentType = "plain/text";
                        }
                        else {
                            responseJson = "Error: Invalid method type!";
                            context.Response.ContentType = "plain/text";
                            context.Response.StatusCode = 400;
                        }
                        break;
                }
                break;
            }
        default:
            break;
    }

    

    using var writer = new StreamWriter(context.Response.OutputStream);
    await writer.WriteLineAsync(responseJson);
    await writer.FlushAsync();
    //}, null);
}