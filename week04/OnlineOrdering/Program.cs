using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        // Order 1 - USA Customer
        Address address1 = new Address("123 Main St", "michigan", "UT", "USA");
        Customer customer1 = new Customer("Luna wills", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P001", 15.99, 2));
        order1.AddProduct(new Product("Keyboard", "P002", 39.99, 1));

        // Order 2 - International Customer
        Address address2 = new Address("456 Maple Ave", "Nigeria", "ON", "rivers street");
        Customer customer2 = new Customer("Frank Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P003", 129.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "P004", 12.50, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}