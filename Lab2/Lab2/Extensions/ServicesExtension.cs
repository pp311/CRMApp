using Lab2.Data;
using Lab2.Repositories;
using Lab2.Repositories.Interfaces;
using Lab2.Services;
using Lab2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

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
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IAccountService, AccountService>();
    }
}
