using System.Net;



HttpListener httpListener = new HttpListener();

const int port = 80;

httpListener.Prefixes.Add($"http://*:{port}/");

httpListener.Start();

Console.WriteLine($"Server started on port '{port}'...");



if(true) {
    while(true) {
        HttpListenerContext context = await httpListener.GetContextAsync();

        if(context.Request.Url.ToString().Contains("user/create") && context.Request.HttpMethod == "POST") {
            using var reader = new StreamReader(context.Request.InputStream);

            var requestStr = await reader.ReadToEndAsync();

            Console.WriteLine($"{context.Request.Url} Request: {requestStr}");

            context.Response.StatusCode = 201;
            using var writer = new StreamWriter(context.Response.OutputStream);
            //await writer.WriteLineAsync(writer.GetType().FullName);
            await writer.FlushAsync();
        }
    }
}




if(false) {
    while(true) {
        HttpListenerContext context = await httpListener.GetContextAsync();
        Console.WriteLine($"Client Connected by link: {context.Request.Url}!");
        using var writer = new StreamWriter(context.Response.OutputStream);

        try {
            //context.Request.Url

            var url = context.Request.Url.ToString();
            if(url.Contains("favicon"))
                continue;

            var lastRoute = url[(url.LastIndexOf('/') + 1)..];

            if(Directory.Exists("assets") == false)
                Directory.CreateDirectory("assets");

            File.Create($"assets/{lastRoute}.txt");

            context.Response.ContentType = "text/plain";
            context.Response.StatusCode = 201;

            await writer.WriteLineAsync($"<h1>{lastRoute.ToUpper()}<h1/>");
            await writer.FlushAsync();
        }
        catch(Exception ex) {
            context.Response.StatusCode = 500;
            await writer.FlushAsync();
            await writer.WriteLineAsync(ex.Message);
        }
    }
}