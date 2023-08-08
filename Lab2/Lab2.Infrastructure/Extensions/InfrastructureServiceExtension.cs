using Lab2.Application.Interfaces;
using Lab2.Domain;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Identity;
using Lab2.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lab2.Infrastructure.Extensions;

public static class InfrastructureServiceExtension
{
    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(InfrastructureServiceExtension));
    }
    
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CRMDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            options.EnableSensitiveDataLogging();
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
        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
    }

    public static void ConfigureInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUserManagerService, UserManagerService>();
        services.AddScoped<IRoleManagerService, RoleManagerService>();
    }
}