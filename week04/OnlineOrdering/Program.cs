using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "PROD001", 1200.00, 1);
        Product product2 = new Product("Mouse", "PROD002", 25.50, 2);
        Product product3 = new Product("Keyboard", "PROD003", 75.00, 1);
        Product product4 = new Product("Monitor", "PROD004", 300.00, 2);
        Product product5 = new Product("Webcam", "PROD005", 50.00, 1);

        // --- Create Addresses ---
        Console.WriteLine("Creating addresses...");
        Address address1 = new Address("123 Main St", "Anytown", "Delta", "USA", "984982");
        Address address2 = new Address("456 Oak Ave", "Otherville", "NY", "USA", "497244M");
        Address address3 = new Address("789 Pine Ln", "Toronto", "ON", "Canada", "749385702"); // International address

        // --- Create Customers ---
        Console.WriteLine("Creating customers...");
        Customer customer1 = new Customer("Alice Smith", address1); // USA customer
        Customer customer2 = new Customer("Bob Johnson", address2); // USA customer (unused in orders but valid)
        Customer customer3 = new Customer("Charlie Brown", address3); // International customer

        // --- Create Orders ---
        Console.WriteLine("Creating orders...");
        // Order 1: For a USA customer with 3 products
        Order order1 = new Order(customer1, new List<Product> { product1, product2, product3 });
        // Order 2: For an International customer with 2 products
        Order order2 = new Order(customer3, new List<Product> { product4, product5 });

        Console.WriteLine("\n--- Order 1 Details ---");
        // Display packing label for Order 1
        Console.WriteLine(order1.GetPackingLabel());
        // Display shipping label for Order 1
        Console.WriteLine(order1.GetShippingLabel());
        // Display total cost for Order 1, formatted to two decimal places
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("--- Order 2 Details ---");
        // Display packing label for Order 2
        Console.WriteLine(order2.GetPackingLabel());
        // Display shipping label for Order 2
        Console.WriteLine(order2.GetShippingLabel());
        // Display total cost for Order 2, formatted to two decimal places
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");
    }
}