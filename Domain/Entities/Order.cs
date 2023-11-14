using Domain.Enums;

namespace Domain.Entities;

public class Order : BaseAuditableEntity
{
    public long TotalPrice { get; set; }
    public long TotalDiscount { get; set; }
    public long FinalPrice { get; set; }
    public OrderStatusEnum OrderStatus { get; set; }
    public int? AddressId { get; set; }
    public Address? Address { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}