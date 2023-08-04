using Lab2.Application.Services;
using Lab2.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Lab2.Application.Extensions;

public static class ApplicationServiceExtension
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IDealService, DealService>();
        services.AddScoped<ILeadService, LeadService>();
        services.AddScoped<IDealProductService, DealProductService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthService, AuthService>(); 
    }
}