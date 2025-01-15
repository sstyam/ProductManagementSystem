using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Models.Entities;

namespace ProductManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        //We will make a constructor for this class-> Manually
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        //{

        //}
        //Otherwise we can press  CTRL+. on (ApplicationDbContext) to generate the constructor using Intelligence
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //We will add a property for the collection we are going to store in the Database

        public DbSet<Product> Products { get; set; }

    }
}
