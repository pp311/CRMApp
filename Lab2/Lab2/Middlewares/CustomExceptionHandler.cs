using System.Net;
using System.Text.Json;
using Lab2.Exceptions;
using Lab2.Logging;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Lab2.Middlewares;

public static class CustomExceptionHandler
{
    public static void UseCustomExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env, IExceptionLogger logger)
    {
        app.UseExceptionHandler(exceptionHandlerApp =>
        {
            exceptionHandlerApp.Run(async context =>
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var exception = context.Features.Get<IExceptionHandlerFeature>()?.Error;
                var message = exception?.Message;
                logger.LogError(exception);

                switch (exception) {
                    case EntityNotFoundException:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    case NotImplementedException:
                        response.StatusCode = (int)HttpStatusCode.NotImplemented;
                        break;
                    case EntityValidationException:
                    case InvalidUpdateException:
                    case InvalidPasswordException:
                    case InvalidRefreshTokenException:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
                
                var isDevelopment = env.IsDevelopment();
                
                var pd = new ProblemDetails
                {
                    Title = isDevelopment ? message : "An error occurred on the server.",
                    Status = response.StatusCode,
                    Detail = isDevelopment ? exception?.StackTrace : null,
                    // Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
                };
                pd.Extensions.Add("traceId", context.TraceIdentifier);

                await response.WriteAsync(JsonSerializer.Serialize(pd));
            });
        });
    }
}