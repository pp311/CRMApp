using Microsoft.AspNetCore.HttpLogging;
using Serilog;

namespace Lab2.Extensions;

public static class LoggingExtension
{
    public static void ConfigureSerilog(this ILoggingBuilder builder, IConfiguration configuration)
    {
        var errorLogger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();   
        builder.AddSerilog(errorLogger);
    }
    
    public static void ConfigureLogging(this IServiceCollection services)
    {
        services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.RequestMethod |
                                    HttpLoggingFields.RequestPath;
        });
    }
}