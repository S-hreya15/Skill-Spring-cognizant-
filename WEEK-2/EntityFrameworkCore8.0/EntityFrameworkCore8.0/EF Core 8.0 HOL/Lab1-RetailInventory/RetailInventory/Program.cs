using System;
using RetailInventory.Data;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext db = new AppDbContext();

            Console.WriteLine("==================================");
            Console.WriteLine(" Retail Inventory Management ");
            Console.WriteLine("==================================");
            Console.WriteLine();

            Console.WriteLine("Entity Framework Core 8.0 configured successfully.");
            Console.WriteLine("Database Context Created Successfully.");
            Console.WriteLine();
            Console.WriteLine("Lab 1 Completed Successfully!");
        }
    }
}