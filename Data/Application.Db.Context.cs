using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using mymvcapp.Models.Entities; // imports the entities folder where we have defined our user

namespace mymvcapp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            public DbSet<User> Users { get; set; }
        }


}

