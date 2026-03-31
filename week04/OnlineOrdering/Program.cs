using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        Address address = new Address("356 N Main St", "Winter Garden", "FL", "US");
        Customer customer = new Customer("John Doe", address);
        Product product1 = new Product("Rice", "45785", 4.5, 5);
        Product product2 = new Product("Beans", "8569", 7.99, 3);
        Product product3 = new Product("Bread", "45785", 5.99, 8);
        Product product4 = new Product("Apples", "13697", 5.74, 2);
        Product product5 = new Product("Cheese", "65312", 1.88, 3);
        Product product6 = new Product("Ice Cream", "97463", 3.50, 1);
        
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        Order currentOrder= new Order(customer, products);
        Console.WriteLine($"Packing Label: \n{currentOrder.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{currentOrder.GetShippingLabel()}\n");
        Console.WriteLine($"Order Total: {currentOrder.GetOrderTotal():C2}\n");

        // second customer order
        Console.WriteLine("Second Order");
        Address address2 = new Address("451 S Main St", "Talanga", "FM", "HN");
        Customer customer2 = new Customer("Jane Doe", address2);
        List<Product> productsJ = new List<Product>();
        productsJ.Add(product4);
        productsJ.Add(product5);
        productsJ.Add(product6);
        Order secondOrder= new Order(customer2, productsJ);
        Console.WriteLine($"Packing Label: \n{secondOrder.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{secondOrder.GetShippingLabel()}\n");
        Console.WriteLine($"Order Total: {secondOrder.GetOrderTotal():C2}\n");
        




    }
}