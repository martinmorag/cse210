public class Receptions : Event
{
    private string _email;

    public Receptions(string eventTitle, string date, string time, string eventType, string address, string email) : base(eventTitle, date, time, eventType, address)
    {
        _email = email;
        SetDescription("a big party with lots of entertaining activities to enjoy the entire evening");
    }
    
    public void ReceptionDetails()
    {
        Address address = new Address(_address);
        Console.WriteLine($"\nThe {_eventTitle} Event will include\n{GetDescription()}.");
        Console.WriteLine($"This Event will take place the {_date} at {_time} in {address.GetAddress()}\n");
        Console.WriteLine($"For this Event you can RSVP to this email: {_email}.");
    } 
}