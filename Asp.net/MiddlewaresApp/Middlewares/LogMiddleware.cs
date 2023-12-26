namespace MiddlewaresApp.Middlewares;

public class LogMiddleware : IMiddleware
{
    private readonly ILogger<LogMiddleware> logger;

    public LogMiddleware(ILogger<LogMiddleware> logger)
    {
        this.logger = logger;
    }
    
    public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next) {
        this.logger.Log(LogLevel.Information, $"PATH: '{httpContext.Request.Path}{httpContext.Request.QueryString.Value}'");
        
        await next.Invoke(httpContext);
    }
}