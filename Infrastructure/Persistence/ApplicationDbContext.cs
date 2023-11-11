using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
{
    
}