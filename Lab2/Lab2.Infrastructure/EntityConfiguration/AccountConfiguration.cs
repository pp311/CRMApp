using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Infrastructure.EntityConfiguration;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.Property(a => a.Name).IsRequired().HasMaxLength((int)StringLength.Medium256);

        builder.Property(a => a.Address).HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(a => a.Email).HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(a => a.Phone).HasMaxLength((int)StringLength.Short32);

        builder.HasIndex(a => new { a.Phone, a.Email }).IsUnique();
    }
}