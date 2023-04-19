using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 5;
        
        Console.WriteLine("What is the magic number? ");
        string magic = Console.ReadLine();
        int number = int.Parse(magic);

        if (number > guess)
        {
            Console.WriteLine("Lower");
        }
        else if (number < guess)
        {
            Console.WriteLine("Higher");
        }
    }
}
