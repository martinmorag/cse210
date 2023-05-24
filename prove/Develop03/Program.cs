using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        
        Reference reference = new Reference("Proverbs", "3", "5");
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding TEST.");
        

        bool display()
        {
            Console.Clear();
            foreach (Word word in scripture._Words)
            {
                Console.Write(word.GetRenderedText() + " ");
            }
            Console.Write(reference.GetReference());
            Console.WriteLine("\n\nPlease enter to continue or 'quit' to finish: ");
            string stop = Console.ReadLine();
            if (stop == "quit")
            {
                return true;
            }
            else
                return false;
        }

        while(true)
        {
            if(display())
                break;
            if(scripture.AllWordsHidden())
                break;

            int counter = 0;
            while(counter < 3)
            {
                Word word = scripture._Words[rnd.Next(scripture._Words.Count)];
                if(word.IsShown())
                {
                    word.Hide();
                    counter++;
                }
                if(scripture.AllWordsHidden())
                    break;
            }
        }
    }
}
