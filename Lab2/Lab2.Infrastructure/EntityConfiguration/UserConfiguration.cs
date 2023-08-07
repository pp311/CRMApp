using Lab2.Domain.Enums;
using Lab2.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Infrastructure.EntityConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.Name).IsRequired().HasMaxLength((int)StringLength.Medium256);

        builder.Property(u => u.Email).IsRequired().HasMaxLength((int)StringLength.Medium256);
        
    }
}