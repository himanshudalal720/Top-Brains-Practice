using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id;
    public string Name;
    public decimal Price;
    public int Stock;
}

class Customer
{
    public int Id;
    public string Name;
    public bool IsBlacklisted;
}

class OrderItem
{
    public Product Product;
    public int Quantity;

    public decimal TotalPrice()
    {
        return Product.Price * Quantity;
    }
}

enum OrderStatus
{
    Pending,
    Shipped,
    Cancelled
}

class Order
{
    public int OrderId;
    public Customer Customer;
    public List<OrderItem> Items = new List<OrderItem>();
    public DateTime OrderDate = DateTime.Now;
    public OrderStatus Status = OrderStatus.Pending;

    public void AddItem(Product product, int quantity)
    {
        if (product.Stock < quantity)
            throw new Exception("Out of Stock!");

        product.Stock -= quantity;

        OrderItem item = new OrderItem();
        item.Product = product;
        item.Quantity = quantity;

        Items.Add(item);
    }

    public decimal GetTotalAmount()
    {
        return Items.Sum(i => i.TotalPrice());
    }

    public void CancelOrder()
    {
        if (Status == OrderStatus.Shipped)
            throw new Exception("Order already shipped!");

        Status = OrderStatus.Cancelled;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        List<Customer> customers = new List<Customer>();
        List<Order> orders = new List<Order>();
        Dictionary<int, Product> productDictionary = new Dictionary<int, Product>();

        // Add products
        products.Add(new Product { Id = 1, Name = "Laptop", Price = 60000, Stock = 10 });
        products.Add(new Product { Id = 2, Name = "Phone", Price = 30000, Stock = 20 });
        products.Add(new Product { Id = 3, Name = "Headphones", Price = 2000, Stock = 5 });

        foreach (var p in products)
            productDictionary[p.Id] = p;

        // Add customers
        customers.Add(new Customer { Id = 1, Name = "Rahul", IsBlacklisted = false });
        customers.Add(new Customer { Id = 2, Name = "Ramesh", IsBlacklisted = false });

        try
        {
            Customer customer = customers[0];

            if (customer.IsBlacklisted)
                throw new Exception("Customer Blacklisted!");

            Order order = new Order();
            order.OrderId = 1001;
            order.Customer = customer;

            order.AddItem(productDictionary[1], 1);
            order.AddItem(productDictionary[2], 1);

            orders.Add(order);

            Console.WriteLine("Order Created Successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // ---------------- LINQ QUERIES ----------------

        Console.WriteLine("\nOrders in Last 7 Days:");
        var recentOrders = orders
            .Where(o => o.OrderDate >= DateTime.Now.AddDays(-7));

        foreach (var o in recentOrders)
            Console.WriteLine(o.OrderId);

        Console.WriteLine("\nTotal Revenue:");
        Console.WriteLine(orders.Sum(o => o.GetTotalAmount()));

        Console.WriteLine("\nMost Sold Product:");
        var mostSold = orders
            .SelectMany(o => o.Items)
            .GroupBy(i => i.Product.Name)
            .OrderByDescending(g => g.Sum(i => i.Quantity))
            .FirstOrDefault();

        if (mostSold != null)
            Console.WriteLine(mostSold.Key);

        Console.WriteLine("\nTop Customers by Spending:");
        var topCustomers = orders
            .GroupBy(o => o.Customer.Name)
            .Select(g => new
            {
                Name = g.Key,
                Total = g.Sum(o => o.GetTotalAmount())
            })
            .OrderByDescending(x => x.Total);

        foreach (var c in topCustomers)
            Console.WriteLine(c.Name);

        Console.WriteLine("\nGroup Orders By Status:");
        var grouped = orders.GroupBy(o => o.Status);
        foreach (var g in grouped)
            Console.WriteLine(g.Key);

        Console.WriteLine("\nProducts with Stock < 10:");
        var lowStock = products.Where(p => p.Stock < 10);
        foreach (var p in lowStock)
            Console.WriteLine(p.Name);
    }
}
