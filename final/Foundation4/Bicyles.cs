public class Biycles : Activity
{
//    List<Biycles> Rides = new List<Biycles>();
    public Biycles(string sport, double distanceOrLaps, double minutes) : base(sport, distanceOrLaps, minutes)
    {
        AddTO(GetSummary());
    }

}