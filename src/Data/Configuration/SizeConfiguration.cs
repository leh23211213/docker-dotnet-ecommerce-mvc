using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.Data.Models;
namespace src.Data.Configuration
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasKey(s => s.SizeId);
            builder.Property(s => s.SizeName).IsRequired().HasMaxLength(50);

            builder.HasMany(s => s.ProductDetails)
                   .WithOne(pd => pd.Size)
                   .HasForeignKey(pd => pd.SizeId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
