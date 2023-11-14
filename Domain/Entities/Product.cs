using Domain.Enums;

namespace Domain.Entities;

public class Product : BaseAuditableEntity
{

    public string Name { get; set; }
    public string Description { get; set; }
    public long Price { get; set; }
    public int TotalSales { get; set; }
    public int Stock { get; set; }
    public StatusEnum Status { get; set; }
    public ICollection<Category> Categories { get; set; }
    public ICollection<ProductVariant> ProductVariants { get; set; }
    public ICollection<Coupon> Coupons { get; set; }
    public ICollection<Media> Medias { get; set; }
    public ICollection<ProductAttributes> ProductAttributes { get; set; }
    public ICollection<ProductReview> ProductReviews { get; set; }
}