using System.Security.Claims;
using System.Text;
using Lab2.Configuration;
using Lab2.Constant;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Extensions;

public static class AuthExtension
{
    public static void ConfigureAuthentication(this IServiceCollection services,
                                               IConfiguration configuration)
    {
        var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>() 
                          ?? throw new NullReferenceException("JwtSettings not found");

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
                options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true, 
                        ValidateAudience = true,  
                        ValidateLifetime = true, 
                        ValidateIssuerSigningKey = true, 
                        ValidIssuer = jwtSettings.ValidIssuer,
                        ValidAudience = jwtSettings.ValidAudience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecurityKey)),
                    };
                });
    }
    
    public static void ConfigureAuthorization(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy(AuthPolicy.AdminOnly, policy => policy.RequireRole(AppRole.Admin));
            
            options.AddPolicy(AuthPolicy.AdminOrOwner, policy => policy.RequireAssertion(context =>
            {
                var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var requestUserId = new HttpContextAccessor().HttpContext?.Request.RouteValues["userId"]?.ToString();
                
                return context.User.IsInRole(AppRole.Admin) || userId == requestUserId; 
            }));
        });
    }
    
}