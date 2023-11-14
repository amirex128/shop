namespace Domain.Entities;

public class ProductAttributes : BaseAuditableEntity
{

    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
}