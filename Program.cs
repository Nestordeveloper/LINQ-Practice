using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Product[] myProducts = new Product[]
        {
            new Product { Name = "Jeans", Category = "Clothing", Price = 24.7 },
            new Product { Name = "Socks", Category = "Clothing", Price = 8.12 },
            new Product { Name = "Scooter", Category = "Vehicle", Price = 99.99 },
            new Product { Name = "Skateboard", Category = "Vehicle", Price = 24.99 },
            new Product { Name = "Skirt", Category = "Clothing", Price = 17.5 }
        };

        IEnumerable<Product> sortProductsByPrice =
            myProducts.OrderByDescending(prod => prod.Price);

        IEnumerable<Product> orderedClothingProducts =
            myProducts.Where(c => c.Category == "Clothing").OrderByDescending(prod => prod.Price);

        Console.WriteLine("Productos ordenados por precio:");
        foreach (var product in sortProductsByPrice)
        {
            Console.WriteLine($"Nombre: {product.Name}, Categoría: {product.Category}, Precio: {product.Price}");
        }

        Console.WriteLine("\nProductos de ropa ordenados por precio:");
        foreach (var product in orderedClothingProducts)
        {
            Console.WriteLine($"Nombre: {product.Name}, Categoría: {product.Category}, Precio: {product.Price}");
        }
    }
}