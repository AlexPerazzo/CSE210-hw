using System;
using Foundation2.Classes;

    


class Program
{
    static void Main(string[] args)
    {
       
        Address address1 = new Address("159 Happy Place", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("789 Basket Road", "Houston", "Ontario", "Canada");

        Customer customer1 = new Customer("Jamie Nebeker", address1);
        Customer customer2 = new Customer("Emma Martindale", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        Product product1 = new Product("Cookie", "111", .99, 3);
        Product product2 = new Product("2012 Camaro", "222", 30299, 4);
        Product product3 = new Product("Spatula", "333", 8.49, 12);

        Product product4 = new Product("Oven Mittens", "444", 8.00, 4);
        Product product5 = new Product("Mug", "555", 10.50, 5);
        Product product6 = new Product("Puppy", "666", 300, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
    
        string shippinglabel1 = order1.CreateShippingLabel();
        Console.WriteLine(shippinglabel1);

        string packinglabel1 = order1.CreatePackingLabel();
        Console.WriteLine(packinglabel1);


        double totalprice1 = order1.ReturnTotalCost();
        Console.WriteLine($"Total Cost of Order: {totalprice1.ToString("C2")}");
        
        Console.WriteLine();

        string shippinglabel2 = order2.CreateShippingLabel();
        Console.WriteLine(shippinglabel2);

        string packinglabel2 = order2.CreatePackingLabel();
        Console.WriteLine(packinglabel2);


        double totalprice2 = order2.ReturnTotalCost();
        Console.WriteLine($"Total Cost of Order: {totalprice2.ToString("C2")}");




    }
}
