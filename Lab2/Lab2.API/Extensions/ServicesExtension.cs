using Lab2.Application.Configuration;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace Lab2.Extensions;

public static class ServicesExtension
{
    
    public static void ConfigureIdentity(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole<int>>(options =>
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

    public static void ConfigureConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
    }
}
