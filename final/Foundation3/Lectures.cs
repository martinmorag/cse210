public class Lectures : Event
{
    private string _speakerName;
    private string _capacity;
    public Lectures(string eventTitle, string date, string time, string eventType, string address, string speakerName, string capacity) : base(eventTitle, date, time, eventType, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        SetDescription("a fulfilling speech about what is going on nowadays with the political state of our country, and how we can contribute to the benefit of all citizens");
    }
    
    public void LectureDetails()
    {
        Address address = new Address(_address);
        Console.WriteLine($"\nThe {_eventTitle} Event will include\n{GetDescription()}.");
        Console.WriteLine($"This Event will take place the {_date} at {_time} in {address.GetAddress()}\n");
        Console.WriteLine($"This Event will have a maximum capacity of {_capacity} and our Speaker will be {_speakerName}.");

    }

    
}