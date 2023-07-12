using Lab2.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Entities.EntityConfiguration;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.Property(a => a.Name).IsRequired().HasMaxLength((int)StringLength.Medium256);

        builder.Property(a => a.Address).HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(a => a.Email).HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(a => a.Phone).HasMaxLength((int)StringLength.Short32);
        
        
    }
}