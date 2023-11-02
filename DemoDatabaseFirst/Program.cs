using DemoDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyStoreContext context = new MyStoreContext();
            var list_category = context.Categories.ToList();
            foreach (var category in list_category)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
            Console.WriteLine();
            var list_product = context.Products.ToList();
            foreach (var product in list_product)
            {
                Console.WriteLine($"{product.ProductId} - {product.ProductName}" +
                    $" - {product.UnitPrice} - {product.UnitsInStock} - {product.Category.CategoryName}");
            }
            Console.WriteLine();
            var list_productByPrice = context.Products.Where(p => p.UnitPrice < 100000).OrderByDescending(p => p.ProductName).ToList();
            foreach (var product in list_productByPrice)
            {
                Console.WriteLine($"{product.ProductId} - {product.ProductName}" +
                    $" - {product.UnitPrice} - {product.UnitsInStock} - {product.Category.CategoryName}");
            }
        }
    }
}
