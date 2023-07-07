public class Running : Activity
{
    public Running(string sport, double distanceOrLaps, double minutes) : base(sport, distanceOrLaps, minutes)
    {
        AddTO(GetSummary());
    }

}
