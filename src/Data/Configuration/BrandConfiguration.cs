using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.Data.Models;
namespace src.Data.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.BrandId);
            builder.Property(b => b.BrandName).IsRequired().HasMaxLength(100);
            builder.Property(b => b.ImageUrl).HasMaxLength(200);

            builder.HasMany(b => b.Products)
                   .WithOne(p => p.Brand)
                   .HasForeignKey(p => p.BrandId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
