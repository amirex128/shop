namespace Domain.Entities;

public class Wishlist: BaseAuditableEntity
{

    public int UserId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}