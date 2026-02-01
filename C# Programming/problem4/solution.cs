using System;
using System.Collections.Generic;

class Product
{
    public Product(int productId, string productName, string category, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
        Price = price;
    }

    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

class Solution
{
    // CREATE
    public static void addProduct(List<Product> productList, Product product)
    {
        productList.Add(product);
    }

    // READ
    public static List<Product> getProductsByCategory(List<Product> productList, string searchCategory)
    {
        List<Product> result = new List<Product>();

        foreach (Product p in productList)
        {
            if (p.Category.Equals(searchCategory, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(p);
            }
        }
        return result;
    }

    // UPDATE
    public static bool updateProductPrice(List<Product> productList, int productId, double newPrice)
    {
        foreach (Product p in productList)
        {
            if (p.ProductId == productId)
            {
                p.Price = newPrice;
                return true;
            }
        }
        return false;
    }

    // DELETE
    public static bool deleteProductById(List<Product> productList, int productId)
    {
        Product toRemove = null;

        foreach (Product p in productList)
        {
            if (p.ProductId == productId)
            {
                toRemove = p;
                break;
            }
        }

        if (toRemove != null)
        {
            productList.Remove(toRemove);
            return true;
        }
        return false;
    }

    public static void Main()
    {
        List<Product> productList = new List<Product>();

        // INPUT 4 PRODUCTS
        for (int i = 0; i < 4; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string category = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            Product p = new Product(id, name, category, price);
            addProduct(productList, p);
        }

        // READ BY CATEGORY
        string searchCategory = Console.ReadLine();
        List<Product> filteredProducts = getProductsByCategory(productList, searchCategory);

        foreach (Product p in filteredProducts)
        {
            if (p.Price > 50000)
                Console.WriteLine("Expensive Product");
            else
                Console.WriteLine("Affordable Product");
        }

        // UPDATE
        int updateId = int.Parse(Console.ReadLine());
        double newPrice = double.Parse(Console.ReadLine());

        bool updated = updateProductPrice(productList, updateId, newPrice);
        Console.WriteLine(updated ? "Price Updated" : "Product Not Found");

        // DELETE
        int deleteId = int.Parse(Console.ReadLine());
        bool deleted = deleteProductById(productList, deleteId);
        Console.WriteLine(deleted ? "Product Deleted" : "Product Not Found");
    }
}
