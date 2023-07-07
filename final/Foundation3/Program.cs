using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("The Big Newsflash", "September 10th", "18:00 h", "Lecture", "47th St.", "Ronaldo Gonzalez", "200");
        lecture.StandardDetails();

        Receptions reception = new Receptions("The Bombastic party", "August 25th", "20:00 h", "Reception", "Jupiter Avenue", "thebestparty@gmail.com");
        reception.ReceptionDetails();

        Outdoors outdoor = new Outdoors("Nature Friends", "July 12th", "15:00 h", "Outdoor Gathering", "Yanika Park", "Sunny");
        outdoor.ShortDescription();
    }
}
