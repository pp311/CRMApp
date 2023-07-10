using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab2.Entities.EntityConfiguration;

public class DealProductConfiguration : IEntityTypeConfiguration<DealProduct>
{
    public void Configure(EntityTypeBuilder<DealProduct> builder)
    {
        builder.HasKey(dp => new {dp.DealId, dp.ProductId});
        
        builder.HasOne(dp => dp.Deal)
            .WithMany(d => d.DealProducts)
            .HasForeignKey(dp => dp.DealId);

        builder.HasOne(dp => dp.Product)
            .WithMany(p => p.DealProducts)
            .HasForeignKey(dp => dp.ProductId);
    }
}