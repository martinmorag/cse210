using System;

class Program
{
    static void Main(string[] args)
    
    {
        
    DisplayWelcomeMessage();

    string name = DisplayUsername();

    int integer = DisplayUsernumber();
  
    int square = Square(integer);
    

    Result(name, square);



    static  void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string DisplayUsername()
    {
        Console.WriteLine("What is your name? ");
        string username = Console.ReadLine();

        return username;
    }
    static int DisplayUsernumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int Square(int integer)
    {
        int Square = integer * integer;
        return Square;
    }
    static void Result(string name, int number)
    {
        Console.WriteLine($"The square number of your favorite number Mr {name} is {number}");
    }


    }
     
}
