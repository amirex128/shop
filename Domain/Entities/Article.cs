namespace Domain.Entities;

public class Article : BaseAuditableEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
    public string Slug { get; set; }

    public int? MediaId { get; set; }
    public Media? Media { get; set; }
    
    public ICollection<Category> Categories { get; set; }
}