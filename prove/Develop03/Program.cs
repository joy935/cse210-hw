using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John", "3", "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.WriteLine("Scripture Memorizer Program");
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            string userChoice = Console.ReadLine();

            //if (Console.ReadKey().Key == ConsoleKey.Enter)
            if (string.IsNullOrWhiteSpace(userChoice))
            {
                Console.Clear();
                if (scripture.IsCompletelyHidden() == true)
                {
                    break;
                }
                else 
                {
                    scripture.HideWords();
                    scripture.HideWords();
                    scripture.HideWords();
                }
            }
            else if (userChoice == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        
    }
}