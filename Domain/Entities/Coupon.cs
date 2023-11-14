namespace Domain.Entities;

public class Coupon : BaseAuditableEntity
{

    public string Code { get; set; }
    public long Amount { get; set; }
    public DateTime ExpiryDate { get; set; }
    public ICollection<Product> Products { get; set; }
}