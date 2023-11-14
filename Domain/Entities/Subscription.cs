namespace Domain.Entities;

public class Subscription : BaseAuditableEntity
{

    public string Email { get; set; }
    public string FullName { get; set; }
}