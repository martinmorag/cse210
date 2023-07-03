using System;
public class Product
{
    private string _banana = "Banana";
    private double _bananaPrice = 1;
    private int _bananaID = 5643;
    private string _pear = "Pear";
    private double _pearPrice = 2;
    private int _pearID = 2392;
    private string _apple = "Apple";
    private double _applePrice = 1.5;
    private int _appleID = 3812;
    private string _watermelon = "Watermelon";
    private double _watermelonPrice = 2.5;
    private int _watermelonID = 1243;
    private float _quantity;

    public string GetBanana()
    {
        return _banana;
    }
    public int GetBananaID()
    {
        return _bananaID;
    }
    public string GetPear()
    {
        return _pear;
    }
    public int GetPearID()
    {
        return _pearID; 
    }
    public string GetApple()
    {
        return _apple;
    }
    public int GetAppleID()
    {
        return _appleID;
    }
    public string GetWatermelon()
    {
        return _watermelon;
    }
    public int GetWatermelonID()
    {
        return _watermelonID;
    }
    public string GetFruit(string fruit)
    {
        if (fruit == "Apple") return _apple;
        else if (fruit == "Pear") return _pear;
        else if (fruit == "Banana") return _banana;
        else return _watermelon;
    }
    public int GetFruitID(string fruit)
    {
        if (fruit == "Apple") return _appleID;
        else if (fruit == "Pear") return _pearID;
        else if (fruit == "Banana") return _bananaID;
        else return _watermelonID;
    }
    public double GetFruitPrice(string fruit)
    {
        if (fruit == "Apple") return _applePrice;
        else if (fruit == "Pear") return _pearPrice;
        else if (fruit == "Banana") return _bananaPrice;
        else return _watermelonPrice;
    }
    public double GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(float quantity)
    {
        _quantity = quantity;
    }
    public double Total(double product, double productTwo, double productThree)
    {
        return product + productTwo + productThree;
    }
}