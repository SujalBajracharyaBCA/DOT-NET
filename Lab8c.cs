using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8c
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main()
        {     
            List<Product> products = new List<Product>
        {
            new Product { Name = "Furniture", Price = 1500.00m },
            new Product { Name = "Shoes", Price = 75.50m },
            new Product { Name = "Clothes", Price = 55.00m },
            new Product { Name = "Watches", Price = 250.99m },
            new Product { Name = "Bags", Price = 150.00m }
        };         
            var sortedProducts = from product in products
                                 orderby product.Price descending
                                 select product;
            Console.WriteLine("Products sorted by price in descending order:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"{product.Name}: Rs {product.Price}");
            }
        }
    }

}
