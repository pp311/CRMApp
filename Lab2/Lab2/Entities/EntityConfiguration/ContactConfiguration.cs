using Lab2.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Entities.EntityConfiguration;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasOne<Account>(c => c.Account)
            .WithMany(a => a.Contacts)
            .HasForeignKey(c => c.AccountId);
        
        builder.Property(c => c.Name).IsRequired().HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(c => c.Email).IsRequired().HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(c => c.Phone).HasMaxLength((int)StringLength.Short32);
    }
}