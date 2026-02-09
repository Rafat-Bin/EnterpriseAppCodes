
using EfCoreIntro;

class Program
{
    static void Main()
    {
        // Create a DbContext instance
        // This automatically uses the configuration in AppDbContext
        using var context = new AppDbContext();

        // Create the database and tables IF they do not already exist
        // This runs once per database file
        context.Database.EnsureCreated();

        // ------------------------
        // INSERT DATA
        // ------------------------

        // Add products to the Products table
        context.Products.Add(new Product
        {
            Name = "Product 1",
            Price = 19.99m
        });

        context.Products.Add(new Product
        {
            Name = "Product 2",
            Price = 29.99m
        });

        context.Products.Add(new Product
        {
            Name = "Product 3",
            Price = 39.99m
        });

        // Add customers to the Customers table
        context.Customers.Add(new Customer
        {
            Name = "Customer 1"
        });

        context.Customers.Add(new Customer
        {
            Name = "Customer 2"
        });

        // SaveChanges sends all pending changes to the database
        // NOTHING is saved until this line runs
        context.SaveChanges();

        // ------------------------
        // QUERY DATA
        // ------------------------

        // Retrieve all products from the database
        var products = context.Products.ToList();

        Console.WriteLine("Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - ${product.Price}");
        }

        // Retrieve all customers from the database
        var customers = context.Customers.ToList();

        Console.WriteLine("\nCustomers:");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name);
        }
    }
}