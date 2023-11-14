using Domain.Enums;

namespace Domain.Entities;

public class Province : BaseEntity
{

    public string Name { get; set; }
    public string Slug { get; set; }
    public StatusEnum Status { get; set; }
    public ICollection<City> Cities { get; set; }
}