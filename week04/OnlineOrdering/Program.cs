using System;

class Program
{
    static void Main()
    {
        // Creating first customer with an address
        Address address1 = new Address("123 Elm Street", "Springfield", "Illinois", "USA");
        Customer client1 = new Customer("Quelitho Gabriel", address1);

        // Creating Order 1 and adding products
        Order order1 = new Order(client1);
        order1.AddItem(new Product("Laptop", "LPT123", 1200, 1));
        order1.AddItem(new Product("Mechanical Keyboard", "KB456", 100, 1));

        // Display results for Order 1
        Console.WriteLine("======== ORDER 1 ========");
        Console.WriteLine(order1.GeneratePackingSlip());
        Console.WriteLine("\n🚚 Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"\n💰 Total Cost: ${order1.ComputeTotal():0.00}\n");

        // Creating second customer with a non-USA address
        Address address2 = new Address("456 Rue st- Louis Jeanty", "Port-au-Prince", "Petion-Ville", "Haiti");
        Customer client2 = new Customer("Kieft Raphter Joly", address2);

        // Creating Order 2 with different products
        Order order2 = new Order(client2);
        order2.AddItem(new Product("Graphics Tablet", "TAB789", 450, 1));
        order2.AddItem(new Product("Digital Stylus", "STY101", 30, 2));

        // Display results for Order 2
        Console.WriteLine("======== ORDER 2 ========");
        Console.WriteLine(order2.GeneratePackingSlip());
        Console.WriteLine("\n🚚 Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"\n💰 Total Cost: ${order2.ComputeTotal():0.00}");
    }
}