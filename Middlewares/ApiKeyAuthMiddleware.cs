using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace RickNMortyDotnetApi.Middlewares;

public class ApiKeyAuthMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;
    public ApiKeyAuthMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }


    public async Task Invoke(HttpContext context)
    {
        if (!context.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName, out var extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Api Key was not provided. (Middleware)");
            return;
        }
        var apiKey = _configuration.GetValue<string>(AuthConstants.ApiKeySectionName)!;
        if (!apiKey.Equals(extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Api Key is not valid. (Middleware)");
            return;
        }
        await _next(context);


    }
}