using Microsoft.EntityFrameworkCore;
using RetailInventoryLab2.Models;

namespace RetailInventoryLab2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryLab2DB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}