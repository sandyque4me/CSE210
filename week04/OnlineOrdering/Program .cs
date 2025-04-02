using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "London", "ENG", "UK");

        // Create customers
        Customer customer1 = new Customer("Sandra", address1);
        Customer customer2 = new Customer("John Doe", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 800m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 20m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P003", 500m, 1));
        order2.AddProduct(new Product("Charger", "P004", 25m, 3));

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");
    }
}
