namespace Domain.Entities;

public class Media : BaseAuditableEntity
{
    public string Path { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }
    public int Size { get; set; }
    
}