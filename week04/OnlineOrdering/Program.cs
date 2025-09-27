using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("Freedom Way", "Accra", "Greater Accra", "GHANA");
        Customer customer1 = new Customer("Jay Young", address1.GetFormattedAddress(),false);

        // Create Order and Add Product
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mouse", "003", 350));
        order1.AddProduct(new Product("Keyboard", "023", 799));

        // Display result
        Console.WriteLine($"{order1.GetPackingLabel()}\n");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotalPrice: {order1.GetOrderCost():0.00}"); // 0.00 leaves total in 2 d.p


        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();


        // Create Address and Customer
        Address address2 = new Address("Wall Street", "New York City", "New York","USA");
        Customer customer2 = new Customer("James Matt", address2.GetFormattedAddress(), true );

        // Create Order and Add Product
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Nokia X7", "009", 757.09m));
        order2.AddProduct(new Product("Samsung A16", "001", 1899.18m));

        // Display result
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotalPrice: {order2.GetOrderCost()}0.00");
    
    }
}