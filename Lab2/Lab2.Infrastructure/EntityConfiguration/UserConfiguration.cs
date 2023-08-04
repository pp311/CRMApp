using Lab2.Domain.Enums;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Infrastructure.EntityConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.Name).IsRequired().HasMaxLength((int)StringLength.Medium256);

        builder.Property(u => u.Email).IsRequired().HasMaxLength((int)StringLength.Medium256);

        builder.HasData(new ApplicationUser
        {
            Name = "admin",
            UserName = "admin@gmail.com",
            NormalizedUserName = "ADMIN@GMAIL.COM",
            PasswordHash = new PasswordHasher<object>().HashPassword(null!, "Admin@123"),
            Email = "admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            Id = 1
        });
    }
}