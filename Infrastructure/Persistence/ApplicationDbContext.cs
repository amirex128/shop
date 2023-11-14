using System.Reflection;
using Domain.Entities;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<User, Role, int>
{
    public DbSet<User> User { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Article> Article { get; set; }
    public DbSet<Basket> Basket { get; set; }
    public DbSet<BasketItem> BasketItem { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Coupon> Coupon { get; set; }
    public DbSet<Media> Media { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<ProductAttributes> ProductAttributes { get; set; }
    public DbSet<ProductVariant> ProductVariant { get; set; }
    public DbSet<ProductReview> ProductReview { get; set; }
    public DbSet<Province> Province { get; set; }
    public DbSet<Return> Return { get; set; }
    public DbSet<Subscription> Subscription { get; set; }
    public DbSet<Wishlist> Wishlist { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.HasDefaultSchema("shop");

        base.OnModelCreating(builder);
    }
}