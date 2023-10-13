using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("16");
        reference.SetReference("John", "3", "16");
        reference.SetText("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        Scripture scripture = new Scripture(reference.GetReference(), reference.GetText());
        
        Word word = new Word();

        while (true)
        {
            Console.WriteLine("Scripture Memorizer Program");
            Console.WriteLine($"{scripture.GetRenderedText()}");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            string userChoice = Console.ReadLine();

            if (userChoice == "quit")
            {
                break;
            }
            // else if (scripture.IsCompletelyHidden() == true)
            // {
            //     break;
            // }
            else if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                scripture.HideWords();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        
    }
}