using System.Data.Common;
using System.Net;
using Lab2.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Lab2.Middlewares;

public class CustomExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<CustomExceptionHandlerMiddleware> _logger;
    private readonly IWebHostEnvironment _env;

    public CustomExceptionHandlerMiddleware(RequestDelegate next, ILogger<CustomExceptionHandlerMiddleware> logger, IWebHostEnvironment env)
    {
        _next = next;
        _logger = logger;
        _env = env;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            // set kiểu trả về là json
            var response = context.Response;
            response.ContentType = "application/json";
            var message = ex.Message;
            _logger.LogError(ex, ex.Message);

            switch (ex)
            {
                case DbUpdateException dbException:
                    if (dbException.InnerException is SqlException sqlException)
                        switch (sqlException.Number)
                        {
                            // Duplicated unique field
                            case 2601:
                                response.StatusCode = (int)HttpStatusCode.BadRequest;
                                message = "Duplicated unique field";
                                break;
                            default:
                                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                break;
                        }
                    break;
                case NotImplementedException:
                    response.StatusCode = (int)HttpStatusCode.NotImplemented;
                    break;
                case InvalidUpdateException:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            var isDevelopment = _env.IsDevelopment();
            var pd = new ProblemDetails
            {
                Title = message,
                Status = response.StatusCode,
                Detail = isDevelopment ? ex.StackTrace : null,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
            };
            pd.Extensions.Add("traceId", context.TraceIdentifier);

            await response.WriteAsync(JsonSerializer.Serialize(pd));
        }
    }
}
