using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Entities.EntityConfiguration;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.Property(a => a.Name).IsRequired().HasMaxLength(256);

        builder.Property(a => a.Address).HasMaxLength(256);
        
        builder.Property(a => a.Email).HasMaxLength(256);
        
        builder.Property(a => a.Phone).HasMaxLength(32);
        
        
    }
}