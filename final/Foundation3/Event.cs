public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    private string _eventType;
    protected string _address;

    public Event(string eventTitle, string date, string time, string eventType, string address)
    {
        _eventTitle = eventTitle;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void StandardDetails()
    {
        Address address = new Address(_address);
        Console.WriteLine($"\nThe {_eventTitle} Event will include\n{GetDescription()}.");
        Console.WriteLine($"This Event will take place the {_date} at {_time} in {address.GetAddress()}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"\nThis is an {_eventType} Event. It is called {_eventTitle}");
        Console.WriteLine($"and it will take place the {_date}");
    }

}