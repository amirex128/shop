using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Persistence.Configurations;

public class OrderConfiguration  : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasMany(p=>p.OrderItems).WithOne(p=>p.Order).HasForeignKey(p=>p.OrderId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p=>p.Address).WithMany().HasForeignKey(p=>p.AddressId).OnDelete(DeleteBehavior.SetNull);
        builder.Property(p=>p.OrderStatus).HasConversion(new EnumToStringConverter<OrderStatusEnum>());
    }
}