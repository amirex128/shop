using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class WishlistConfiguration : IEntityTypeConfiguration<Wishlist>
{
    public void Configure(EntityTypeBuilder<Wishlist> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasOne(p=>p.Product).WithMany().HasForeignKey(p=>p.ProductId).OnDelete(DeleteBehavior.Cascade);
    }
}