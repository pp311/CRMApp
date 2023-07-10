using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Entities.EntityConfiguration;

public class LeadConfiguration : IEntityTypeConfiguration<Lead>
{
    public void Configure(EntityTypeBuilder<Lead> builder)
    {
        builder.HasOne<Account>(l => l.Account)
            .WithMany(a => a.Leads)
            .HasForeignKey(l => l.AccountId);
        
        builder.Property(l => l.Title).IsRequired().HasMaxLength(256);
        
        builder.Property(l => l.Description).HasMaxLength(1024);
        
        builder.Property(l => l.DisqualifiedDescription).HasMaxLength(256);
    }
}