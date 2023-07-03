using System;

class Program
{
    static void Main(string[] args)
    {
        
        Order Order = new Order();
        Product order = new Product();
        Address customer = new Address();
        Customer person = new Customer();

        // FIRST ORDER
        
        Order.TheOrder("Selene Lezcano", "Apple", "Watermelon", "Pear");
        Order.PackagingLabel("Apple", "Watermelon", "Pear");
        Order.ShippingLabel("Russell Crowe St.", "Cumberland", "California", "USA");
        Order.ShippingCost();  

        // SECOND ORDER

        Order.TheOrder("Martin Moraga", "Banana", "Watermelon", "Watermelon");
        Order.PackagingLabel("Banana", "Watermelon", "Watermelon");
        Order.ShippingLabel("Louis Vuitton", "Virasoro", "Corrientes", "Argentina");
        Order.ShippingCost();    
    }
}
