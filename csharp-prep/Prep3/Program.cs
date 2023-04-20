using System;

class Program
{
    static void Main(string[] args)
    {
        /* int guess = 5;
        
        
        
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
        else if (number == guess)
        {
            Console.WriteLine("You guessed it!");
        } */
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 
    }   
}
