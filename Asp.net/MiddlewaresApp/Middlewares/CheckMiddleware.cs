using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MiddlewaresApp.Middlewares;

public class CheckMiddleware
{
    private readonly RequestDelegate next;
    public CheckMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext, ILogger<CheckMiddleware> logger)
    {
        if(httpContext.Request.Scheme != "https") {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;

            await httpContext.Response.WriteAsJsonAsync(new {
                Message = $"Change your scheme to https!",
            });
            return;
        }

        await next.Invoke(httpContext);
    }
}