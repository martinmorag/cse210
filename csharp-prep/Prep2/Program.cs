using System;

class Program
{
    static void Main(string[] args)
    {
        int y = 90;
        int z = 80;
        int i = 70;
        int u = 60;

        Console.WriteLine("What is your score? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);

        


        if (number >= y)
        {
            Console.WriteLine("A");
        }
        else if (number >= z)
        {
            Console.WriteLine("B");
        }
        else if (number >= i)
        {
            Console.WriteLine("C");
        }
        else if (number >= u)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
