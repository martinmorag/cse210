public class Swimming : Activity
{
//    List<Activity> sports = new List<Activity>();
    public Swimming(string sport, double distanceOrLaps, double minutes) : base(sport, distanceOrLaps, minutes)
    {
        AddTO(GetSummary());
    }
    public override double GetDistance()
        {
            return _distanceOrLaps * 50 / 1000;
        }
    
    
}