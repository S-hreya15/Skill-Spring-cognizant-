using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventoryLab5.Data;
using RetailInventoryLab5.Models;

namespace RetailInventoryLab5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("===== Lab 5: Retrieving Data =====");

            // Retrieve all products
            var products = await context.Products.ToListAsync();

            Console.WriteLine("\nAll Products:");

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            // Find by Id
            var product = await context.Products.FindAsync(1);

            Console.WriteLine();

            if (product != null)
                Console.WriteLine($"Found: {product.Name}");
            else
                Console.WriteLine("Product with ID 1 not found.");

            // First product with price > 5000
            var expensive = await context.Products
                .FirstOrDefaultAsync(p => p.Price > 5000);

            if (expensive != null)
                Console.WriteLine($"Expensive Product: {expensive.Name}");
            else
                Console.WriteLine("No expensive product found.");
        }
    }
}