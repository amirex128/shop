using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(p=>p.Orders).WithOne(p=>p.User).HasForeignKey(p=>p.UserId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(p=>p.Wishlists).WithOne().HasForeignKey(p=>p.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.OwnsOne(p => p.Social);
    }
}