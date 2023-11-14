﻿using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Persistence.Configurations;

public class ProductConfiguration  : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasMany(p => p.ProductVariants).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.Coupons).WithMany(p=>p.Products);
        builder.HasMany(p => p.Medias).WithMany();
        builder.HasMany(p => p.ProductAttributes).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(p => p.ProductReviews).WithOne().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        builder.Property(p=>p.Status).HasDefaultValue(StatusEnum.Active).HasConversion(new EnumToStringConverter<StatusEnum>());
    }
}