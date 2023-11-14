using Domain.Enums;

namespace Domain.Entities;

public class Return : BaseAuditableEntity
{
    public string ReturnReason { get; set; }
    public OrderStatusEnum OrderStatus { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int OrderItemId { get; set; }
    public OrderItem OrderItem { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}