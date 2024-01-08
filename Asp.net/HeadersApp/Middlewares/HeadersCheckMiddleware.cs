namespace HeadersApp.Middlewares;

// созать middleware который проверяет наличие header-а с ключом "SecretHeader"

// если header
// есть: пропустить дальше
// нет: вернуть 401 status code
public class HeadersCheckMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var headerValues = context.Request.Headers["SecretHeader"];
        
        if(headerValues.Any()) {
            context.Response.Headers.Add(
                key: "Log-Id",
                value: new string[] { Guid.NewGuid().ToString() });

            await next.Invoke(context);
        }
        else {
            context.Response.StatusCode = 401;
        }
    }
}