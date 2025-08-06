using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("--- Online Ordering Program ---");

        // --- Create Addresses ---
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("45 Rue de la Paix", "Paris", "Ile-de-France", "France");
        Address address3 = new Address("789 Oak Ave", "Springfield", "IL", "USA");

        // --- Create Customers ---
        Customer customer1 = new Customer("Alice Smith", address1);
        Customer customer2 = new Customer("Pierre Dubois", address2);
        Customer customer3 = new Customer("Bob Johnson", address3);

        // --- Create Products ---
        Product productA = new Product("Laptop", "LAP001", 1200.00, 1);
        Product productB = new Product("Mouse", "MOU005", 25.50, 2);
        Product productC = new Product("Keyboard", "KEY010", 75.00, 1);
        Product productD = new Product("Monitor", "MON002", 300.00, 1);
        Product productE = new Product("Webcam", "WEB003", 50.00, 3);
        Product productF = new Product("Headphones", "HP001", 150.00, 1);

        // --- Create Orders ---

        // Order 1 
        List<Product> order1Products = new List<Product> { productA, productB };
        Order order1 = new Order(customer1, order1Products);

        // Order 2 
        List<Product> order2Products = new List<Product> { productC, productD, productE };
        Order order2 = new Order(customer2, order2Products);

        // Order 3 
        List<Product> order3Products = new List<Product> { productF, productB, productE };
        Order order3 = new Order(customer3, order3Products);


        // --- Display Order Details ---

        Console.WriteLine("\n=====================================");
        Console.WriteLine("Displaying Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}"); // :F2 formats to 2 decimal places

        Console.WriteLine("\n=====================================");
        Console.WriteLine("Displaying Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");

        Console.WriteLine("\n=====================================");
        Console.WriteLine("Displaying Order 3 Details:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():F2}");

        Console.WriteLine("\n--- End of Program ---");
    }
}
