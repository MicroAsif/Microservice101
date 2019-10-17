using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.API.Service
{
    public static class ProductService
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {Id = 101, Name = "Chal", Price = 66},
                new Product {Id = 102, Name = "Dal", Price = 33},
                new Product {Id = 103, Name = "Egg", Price = 7},
            };
        }
        public static Product GetProduct(int productId)
        {
            return GetProducts().FirstOrDefault(x => x.Id == productId);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
