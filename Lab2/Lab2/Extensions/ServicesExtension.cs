using Lab2.Data;
using Lab2.Logging;
using Lab2.Repositories;
using Lab2.Repositories.Interfaces;
using Lab2.Services;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Lab2.Extensions;

public static class ServicesExtension
{
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CRMDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }

    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IDealRepository, DealRepository>();
        services.AddScoped<ILeadRepository, LeadRepository>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IDealProductRepository, DealProductRepository>();
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IDealService, DealService>();
        services.AddScoped<ILeadService, LeadService>();
        services.AddScoped<IDealProductService, DealProductService>();
    }
    
    public static void ConfigureSerilog(this ILoggingBuilder builder, IConfiguration configuration)
    {
        var errorLogger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();   
        builder.AddSerilog(errorLogger);
    }
    
    public static void ConfigureLogging(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.RequestMethod |
                                    HttpLoggingFields.RequestPath;
        });

        services.AddSingleton<IExceptionLogger, ExceptionLogger>();
    }
}
