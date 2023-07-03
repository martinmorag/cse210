using System;
public class Order
{
    
    

    // FIRST 
    
    Product order = new Product();
    Address customer = new Address();
    Customer person = new Customer();

    public void TheOrder(string name, string firstSelected, string secondSelected, string thirdSelected)
    {
        person.SetName(name);
        Console.WriteLine($"Customer's name: {person.GetName()}\n");
        Console.WriteLine($"First product: {order.GetFruit(firstSelected)}");
        Console.WriteLine($"Second product: {order.GetFruit(secondSelected)}");
        Console.WriteLine($"Third product: {order.GetFruit(thirdSelected)}\n");
        
        Console.WriteLine($"The total is: ${order.Total(order.GetFruitPrice(firstSelected), order.GetFruitPrice(secondSelected), order.GetFruitPrice(thirdSelected)) } dollars.");
    }

    
    public void PackagingLabel(string firstSelected, string secondSelected, string thirdSelected)
    {
        Console.WriteLine("\nPackaging Label:\n");
        Console.WriteLine($"Product name: {order.GetFruit(firstSelected)}");
        Console.WriteLine($"ID: {order.GetFruitID(firstSelected)}");
        Console.WriteLine($"Product name: {order.GetFruit(secondSelected)}");
        Console.WriteLine($"ID: {order.GetFruitID(secondSelected)}");
        Console.WriteLine($"Product name: {order.GetFruit(thirdSelected)}");
        Console.WriteLine($"ID: {order.GetFruitID(thirdSelected)}\n");
    }
    
    public void ShippingLabel(string street, string city, string stateProvince, string country)
    {
        Console.WriteLine("\nShipping Label:\n");
        Console.WriteLine(person.GetName());
        customer.SetStreet(street);
        customer.SetCity(city);
        customer.SetStateOrProvince(stateProvince);
        customer.SetCountry(country);
        Console.WriteLine($"{customer.AllAddress()}\n");
        
    }

    public void ShippingCost()
    {
        customer.IfUSA();
    }


}   