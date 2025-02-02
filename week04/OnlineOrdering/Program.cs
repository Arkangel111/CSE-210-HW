using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        Product product1 = new Product("Product A", "A1234", 5, 10.99);
        Product product2 = new Product("Product B", "B5678", 3, 9.99);
        Product product3 = new Product("Product C", "C9012", 2, 49.99);
        Product product4 = new Product("Product D", "D3456", 1, 19.99);

        Order order1 = new Order(customer1, new List<Product>());
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2, new List<Product>());
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.TotalCost());
        Console.WriteLine("=====================");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.TotalCost());
        Console.WriteLine("=====================");
    }
}