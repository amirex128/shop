using Domain.Enums;

namespace Domain.Entities;

public class City : BaseEntity
{
 
    public string Name { get; set; }
    public string Slug { get; set; }
    public StatusEnum Status { get; set; }

    public int ProvinceId { get; set; }
    public Province Province { get; set; }
}