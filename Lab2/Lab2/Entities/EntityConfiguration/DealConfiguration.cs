using Lab2.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Entities.EntityConfiguration;

public class DealConfiguration : IEntityTypeConfiguration<Deal>
{
    public void Configure(EntityTypeBuilder<Deal> builder)
    {
        builder.HasOne<Lead>(d => d.Lead)
            .WithMany(l => l.Deals)
            .HasForeignKey(d => d.LeadId);
        
        builder.HasOne<Account>(d => d.Account)
            .WithMany(a => a.Deals)
            .HasForeignKey(d => d.AccountId);
        
        builder.Property(d => d.Title).IsRequired().HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(d => d.Description).HasMaxLength((int)StringLength.Long1024);
        
    }
}