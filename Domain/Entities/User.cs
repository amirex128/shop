using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long NationalCode { get; set; }
    public Social Social { get; set; }
    public ICollection<Wishlist> Wishlists { get; set; }
    public ICollection<Address> Addresses { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<ProductReview> ProductReviews { get; set; }
    public ICollection<Return> Returns { get; set; }
}

public class Social
{
    public string Telegram { get; set; }
    public string Instagram { get; set; }
    public string Twitter { get; set; }
    
} 