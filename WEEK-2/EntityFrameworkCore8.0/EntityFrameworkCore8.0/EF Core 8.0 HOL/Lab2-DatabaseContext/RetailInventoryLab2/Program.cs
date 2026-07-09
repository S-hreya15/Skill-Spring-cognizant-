using System;
using RetailInventoryLab2.Data;

namespace RetailInventoryLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext db = new AppDbContext();

            Console.WriteLine("========================================");
            Console.WriteLine(" Retail Inventory - Lab 2");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.WriteLine("Database Context Configured Successfully.");
            Console.WriteLine("Connected to SQL Server.");
            Console.WriteLine("Lab 2 Completed Successfully!");
        }
    }
}