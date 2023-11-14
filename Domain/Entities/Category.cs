namespace Domain.Entities;

public class Category : BaseAuditableEntity
{
    public string Name { get; set; }
    public int? ParentCategoryId { get; set; }
    public ICollection<Category> SubCategories { get; set; }
    public ICollection<Product> Products { get; set; }
    public ICollection<Article> Articles { get; set; }
}