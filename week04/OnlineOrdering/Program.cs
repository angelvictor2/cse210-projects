using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "Utah", "USA");
        Customer customer1 = new Customer("Angel Victor", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Apple", "Ap", 2.50, 5));
        order1.AddProduct(new Product("Watermelon", "Wt", 10.80, 2));

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine("-----------------------------------");

        Address address2 = new Address("30 calle", "Mazatenango", "Suchitepequez", "Guatemala");
        Customer customer2 = new Customer("Luis Victor", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Onion", "ON", 5.50, 4));
        order2.AddProduct(new Product("Tomato", "TM", 5, 3));

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
        Console.WriteLine("-----------------------------------");


    }
}