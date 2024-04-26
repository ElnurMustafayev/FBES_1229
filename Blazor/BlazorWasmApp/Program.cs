using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasmApp;
using BlazorWasmApp.Providers;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

builder.Services.AddAuthorizationCore(options => {
    options.AddPolicy(
        "developer", 
        builder => builder.RequireRole("developer", "tech leader")
        );
});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("identity", async (serviceProvider, client) => {
    client.BaseAddress = new Uri("http://localhost:5295/");

    //var localStorageService = serviceProvider.GetRequiredService<ILocalStorageService>();
    //var accessToken = await localStorageService.GetItemAsStringAsync("accessToken");
    //client.DefaultRequestHeaders.Add("jwt", accessToken);
});

await builder.Build().RunAsync();
