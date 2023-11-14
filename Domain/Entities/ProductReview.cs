
namespace Domain.Entities;

public class ProductReview  : BaseAuditableEntity
{
    public int Rating { get; set; }
    public string ReviewText { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    
}