public class Outdoors : Event
{
    private string _weather;

    public Outdoors(string eventTitle, string date, string time, string eventType, string address, string weather) : base(eventTitle, date, time, eventType, address)
    {
        _weather = weather;
        SetDescription("various activities to take advantage of the place we are located, such as a football game.");
    }

    public void OutdoorDetails()
    {
        Address address = new Address(_address);
        Console.WriteLine($"\nThe {_eventTitle} Event will include\n{GetDescription()}.");
        Console.WriteLine($"This Event will take place the {_date} at {_time} in {address.GetAddress()}\n");
        Console.WriteLine($"For this particular Event the weather will be {_weather}.");
    }
}