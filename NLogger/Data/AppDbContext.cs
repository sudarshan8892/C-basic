using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLogger.Models;

namespace NLogger.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
         public DbSet<ApplicationUser> ApplicationUsers { get; set; }
         public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
