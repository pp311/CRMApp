using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories;
using Lab2.Repositories.Interfaces;
using Lab2.Services;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
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
    
    public static void ConfigureIdentity(this IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole<int>>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = true;
                
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<CRMDbContext>()
            .AddDefaultTokenProviders();
    }
}
