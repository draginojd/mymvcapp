using Microsoft.EntityFrameworkCore;
using mymvcapp.Models;

namespace mymvcapp.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
        
        }
        public DbSet<User> UserRegistration { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> UserLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-8E0C2UV\\SQLEXPRESS;initial catalog=MyMvcAppDB;trusted_connection=true;TrustServerCertificate=True");
        }
      //  public DbSet<mymvcapp.Models.Customers> Customer { get; set; } = default!;
    }

}
