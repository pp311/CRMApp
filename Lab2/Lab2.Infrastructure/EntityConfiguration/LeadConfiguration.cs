using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Infrastructure.EntityConfiguration;

public class LeadConfiguration : IEntityTypeConfiguration<Lead>
{
    public void Configure(EntityTypeBuilder<Lead> builder)
    {
        builder.HasOne<Account>(l => l.Account)
            .WithMany(a => a.Leads)
            .HasForeignKey(l => l.AccountId);
        
        builder.Property(l => l.Title).IsRequired().HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(l => l.Description).HasMaxLength((int)StringLength.Long1024);
        
        builder.Property(l => l.DisqualifiedDescription).HasMaxLength((int)StringLength.Long1024);
    }
}