using System;
using RetailInventoryLab3.Data;

namespace RetailInventoryLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext db = new AppDbContext();

            Console.WriteLine("========================================");
            Console.WriteLine(" Entity Framework Core 8.0 - Lab 3");
            Console.WriteLine("========================================");

            Console.WriteLine("Migration Project Created Successfully.");
            Console.WriteLine("Ready to Generate Migrations.");
        }
    }
}