using Microsoft.EntityFrameworkCore;
using RetailInventoryLab5.Models;

namespace RetailInventoryLab5.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryLab5DB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}