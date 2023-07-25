using System.Text;
using Lab2.Configuration;
using Lab2.Data;
using Lab2.Logging;
using Lab2.Entities;
using Lab2.Identity;
using Lab2.Repositories;
using Lab2.Repositories.Interfaces;
using Lab2.Services;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Microsoft.IdentityModel.Tokens;

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
        services.AddScoped<IUserRepository, UserRepository>();
        
        // services.AddScoped<IUserStore<User>, CustomUserStore>();
        // services.AddScoped<UserManager<User>, CustomUserManager>();
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IDealService, DealService>();
        services.AddScoped<ILeadService, LeadService>();
        services.AddScoped<IDealProductService, DealProductService>();
        services.AddScoped<IUserService, UserService>();
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

    public static void ConfigureAuthentication(this IServiceCollection services,
                                               IConfiguration configuration)
    {
        var jwtSettings = configuration.GetSection("JwtSettings");

        services.AddAuthentication()
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
                options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true, //The issuer is the actual server that created the token
                        ValidateAudience = true, //The receiver of the token is a valid recipient 
                        ValidateLifetime = true, //The token has not expired
                        ValidateIssuerSigningKey = true, //The signing key is valid and is trusted by the server
                        ValidIssuer = jwtSettings["validIssuer"],
                        ValidAudience = jwtSettings["validAudience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                            .GetBytes(jwtSettings.GetSection("securityKey").Value 
                                      ?? throw new InvalidOperationException("No security key found"))),
                    };
                });
    }
    
    public static void ConfigureConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
    }
}
