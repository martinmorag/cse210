public class Activity
{
    public List<string> sports = new List<string>();

    DateTime currentDateTime = DateTime.Now;
    protected string _sport;
    protected string _date = DateTime.Now.ToString("dd MMM yyyy");
    protected double _distanceOrLaps;
    protected double _speed;
    protected double _pace;
    protected double _minutes;
    
    public Activity()
    {

    }
    public Activity(string sport, double distanceOrLaps, double minutes)
    {
        _sport = sport;
        _distanceOrLaps = distanceOrLaps;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }
    public virtual double GetDistance()
    {
        return _distanceOrLaps;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public string GetSpeed()
    {
        double number = (_distanceOrLaps / _minutes) * 60;
        string result = number.ToString("F1");
        return result;
    }
    public string GetPace()
    {
        double number = _minutes / _distanceOrLaps;
        string result = number.ToString("F1");
        return result;
    }
    public string GetSummary()
    {
        return $"\n{GetDate()} {_sport} ({_minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km.";
    }
    public virtual void AddTO(string thing)
    {
        sports.Add(thing);
    }
    public void TheList()
    {
        foreach(string sport in sports)
            Console.WriteLine(sport);
    }
}