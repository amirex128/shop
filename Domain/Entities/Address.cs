﻿
namespace Domain.Entities;

public class Address : BaseAuditableEntity
{
    public string Title { get; set; }
    public string AddressLine { get; set; }
    public string PostalCode { get; set; }
    
    public int CityId { get; set; }
    public City City { get; set; }
    public int ProvinceId { get; set; }
    public Province Province { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}