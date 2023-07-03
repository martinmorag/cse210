using System;
public class Customer
{
    private string _name;

    public Customer()
    {
        
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    Address Info = new Address();
    public void Country()
    {
        Info.IfUSA();
    }
    public string GetAddress()
    {
        return Info.AllAddress();
    }
}