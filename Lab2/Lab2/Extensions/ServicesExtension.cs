using Lab2.Data;
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
}