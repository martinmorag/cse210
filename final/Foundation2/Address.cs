using System;
public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address()
    {
    
    }

    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }
    public void SetStateOrProvince(string stateProvince)
    {
        _stateOrProvince = stateProvince;
    }
   
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public void IfUSA()
    {
        if (GetCountry() == "USA")
        {
           Console.WriteLine("Your shipping cost will be $5 dollars.");
        }
        else 
            Console.WriteLine("Your shipping cost will be $35 dollars.");
    }
    public string AllAddress()
    {
        return $"Customer's Address: \nStreet: {_street} \nCity: {_city} \nState or Province: {_stateOrProvince} \nCountry: {_country}";
    }

}