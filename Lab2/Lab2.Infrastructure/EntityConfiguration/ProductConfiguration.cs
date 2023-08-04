using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Infrastructure.EntityConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength((int)StringLength.Medium256);
        
        builder.Property(p => p.ProductCode).HasMaxLength((int)StringLength.Short32);

        builder.HasIndex(p => p.ProductCode).IsUnique();
    }
}