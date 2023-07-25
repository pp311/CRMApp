using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Extensions;

public static class AuthExtension
{
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
    
}