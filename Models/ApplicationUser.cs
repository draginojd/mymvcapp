using Microsoft.EntityFrameworkCore;

namespace mymvcapp.Models
{
    public class ApplicationUser:DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options) 
        {
        
        }
        public DbSet<User> UserRegistration { get; set; }
    }
}
