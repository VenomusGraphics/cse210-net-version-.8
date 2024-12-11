using System;

class Program
{
    static void Main()
    {
        // Create some products
        Product product1 = new Product("Laptop", "A001", 999.99, 1);
        Product product2 = new Product("Mouse", "B002", 25.50, 2);
        Product product3 = new Product("Keyboard", "C003", 45.75, 1);
        Product product4 = new Product("Monitor", "D004", 150.00, 2);

        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
        Console.WriteLine();
    }
}
