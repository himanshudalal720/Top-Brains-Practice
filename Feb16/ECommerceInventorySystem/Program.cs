using System;
using System.Collections.Generic;
using System.Linq;

// Base product interface
public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; set; } // setter added for price updates
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// 1. Create a generic repository for products
public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();
    
    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        // Rule: Product ID must be unique
        // Rule: Price must be positive
        // Rule: Name cannot be null or empty
        // Add to collection if validation passes

        if (product == null)
            throw new ArgumentNullException(nameof(product));

        if (string.IsNullOrWhiteSpace(product.Name))
            throw new ArgumentException("Product name cannot be empty.");

        if (product.Price <= 0)
            throw new ArgumentException("Price must be positive.");

        if (_products.Any(p => p.Id == product.Id))
            throw new ArgumentException("Product ID must be unique.");

        _products.Add(product);
    }
    
    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(predicate);
    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
        return _products.Sum(p => p.Price);
    }

    public List<T> GetAll() => _products;
}

// 2. Specialized electronic product
public class ElectronicProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; set; }
    public string Brand { get; set; }
}

public class ClothingProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category => Category.Clothing;
    public string Size { get; set; }
}

// 3. Create a discounted product wrapper
public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;
    
    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        // Discount must be between 0 and 100

        if (product == null)
            throw new ArgumentNullException(nameof(product));

        if (discountPercentage < 0 || discountPercentage > 100)
            throw new ArgumentException("Discount must be between 0 and 100.");

        _product = product;
        _discountPercentage = discountPercentage;
    }
    
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => 
        _product.Price * (1 - _discountPercentage / 100);
    
    // TODO: Override ToString to show discount details
    public override string ToString()
    {
        return $"{_product.Name} | Original: {_product.Price:C} | " +
               $"Discount: {_discountPercentage}% | Final: {DiscountedPrice:C}";
    }
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
        Console.WriteLine("\n--- All Products ---");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - {p.Price:C}");

        // b) Find the most expensive product
        var mostExpensive = products.OrderByDescending(p => p.Price).FirstOrDefault();
        Console.WriteLine($"\nMost Expensive: {mostExpensive?.Name} - {mostExpensive?.Price:C}");

        // c) Group products by category
        Console.WriteLine("\n--- Grouped by Category ---");
        var grouped = products.GroupBy(p => p.Category);
        foreach (var group in grouped)
        {
            Console.WriteLine($"\nCategory: {group.Key}");
            foreach (var item in group)
                Console.WriteLine($"  {item.Name} - {item.Price:C}");
        }

        // d) Apply 10% discount to Electronics over $500
        Console.WriteLine("\n--- 10% Discount on Electronics over $500 ---");
        foreach (var p in products.Where(p =>
                     p.Category == Category.Electronics && p.Price > 500))
        {
            var discounted = new DiscountedProduct<T>(p, 10);
            Console.WriteLine(discounted);
        }
    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        // Handle exceptions gracefully

        foreach (var product in products)
        {
            try
            {
                product.Price = priceAdjuster(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating {product.Name}: {ex.Message}");
            }
        }
    }
}

// 5. TEST SCENARIO: Your tasks:
// a) Implement all TODO methods with proper error handling
// b) Create a sample inventory with at least 5 products
// c) Demonstrate:
//    - Adding products with validation
//    - Finding products by brand (for electronics)
//    - Applying discounts
//    - Calculating total value before/after discount
//    - Handling a mixed collection of different product types

class Program
{
    static void Main()
    {
        var repo = new ProductRepository<IProduct>();

        // Adding products with validation
        try
        {
            repo.AddProduct(new ElectronicProduct
            {
                Id = 1,
                Name = "iPhone 15",
                Price = 1200,
                Brand = "Apple",
                WarrantyMonths = 24
            });

            repo.AddProduct(new ElectronicProduct
            {
                Id = 2,
                Name = "Gaming Laptop",
                Price = 1500,
                Brand = "Asus",
                WarrantyMonths = 12
            });

            repo.AddProduct(new ClothingProduct
            {
                Id = 3,
                Name = "T-Shirt",
                Price = 25,
                Size = "M"
            });

            repo.AddProduct(new ClothingProduct
            {
                Id = 4,
                Name = "Jacket",
                Price = 120,
                Size = "L"
            });

            repo.AddProduct(new ElectronicProduct
            {
                Id = 5,
                Name = "Bluetooth Speaker",
                Price = 300,
                Brand = "Sony",
                WarrantyMonths = 18
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Validation Error: {ex.Message}");
        }

        Console.WriteLine($"\nTotal Inventory Value: {repo.CalculateTotalValue():C}");

        // Finding products by brand
        var electronicsByBrand = repo.FindProducts(p =>
            p is ElectronicProduct ep && ep.Brand == "Apple");
            

        Console.WriteLine("\n--- Electronics by Brand (Apple) ---");
        foreach (var item in electronicsByBrand)
            Console.WriteLine(item.Name);

        var manager = new InventoryManager();
        manager.ProcessProducts(repo.GetAll());

        // Applying bulk price update
        Console.WriteLine("\n--- Applying 5% Price Increase ---");
        manager.UpdatePrices(repo.GetAll(), p => p.Price * 1.05m);

        Console.WriteLine($"New Total Value: {repo.CalculateTotalValue():C}");

        Console.ReadKey();
    }
}
