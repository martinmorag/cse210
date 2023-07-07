using System;

class Program
{
    static void Main(string[] args)
    {
        
        Running race = new Running("Running", 4.8, 30);
        Swimming dive = new Swimming("Siwmming", 20, 40);
        Biycles ride = new Biycles("Cycling", 6, 25);
        race.TheList();
        dive.TheList();
        ride.TheList();
    }
}
