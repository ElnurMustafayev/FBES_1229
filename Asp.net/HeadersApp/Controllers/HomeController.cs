using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace HeadersApp.Controllers;

[Route("/[controller]/[action]")]
public class HomeController : ControllerBase
{
    public IActionResult Test() {
        return base.Created(
            uri: "https://google.com",// base.HttpContext.Request.Path.Value,
            value: new { name = "Bob" }
        );

        return base.NotFound(new {
            success = false,
            message = "something..."
        });
    }

    [HttpGet("/api/[controller]/[action]")]
    public IActionResult SetHeaders() {
        for (int i = 0; i < 5; i++)
        {
            base.HttpContext.Response.Headers.Add(
                key: i.ToString(),
                value: new string[] { Guid.NewGuid().ToString() });
        }

        return base.NoContent();
    }

    [HttpGet("/api/[controller]/Header")]
    public IActionResult GetHeader(string? headerName) {
        if(string.IsNullOrEmpty(headerName)) {
            return base.BadRequest("HeaderName must be not empty!");
        }

        var HeaderValues = base.HttpContext.Request.Headers[headerName];

        if(string.IsNullOrEmpty(HeaderValues)) {
            return base.NotFound($"Please send header with key '{headerName}'");
        }

        var result = string.Join(" * ", HeaderValues);

        return Ok(result);
    }


    [HttpGet("/api/[controller]/Headers")]
    public string GetHeaders() {
        var headers = base.HttpContext.Request.Headers;

        StringBuilder sb = new StringBuilder(headers.Count * 10);
        foreach (var headerItem in base.HttpContext.Request.Headers)
        {
            sb.Append(headerItem.Key + ": ");
            foreach (var headerValue in headerItem.Value)
            {
                sb.Append(headerValue);
            } 
            sb.Append("\n");
        } 

        return sb.ToString();
    }
}