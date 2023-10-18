using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Example with a single verse
        // Scripture scripture = new Scripture("John", "3", "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Example with a range of verses
        // Scripture scripture = new Scripture("Proverbs", "3", "5", "6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        // Load scriptures from a file
        string fileName = "scriptures.txt";
        string [] lines = System.IO.File.ReadAllLines(fileName);
        
        Random random = new Random();
        Scripture scripture = null;
        
        int randomIndex = random.Next(0, lines.Length);

        foreach (string line in lines)
        {
            string [] parts = line.Split("~");

            if (parts.Length == 4)
            {
                string book = parts[0];
                string chapter = parts[1];
                string verse = parts[2];
                string text = parts[3];
            }
            else if (parts.Length == 5)
            {
                string book = parts[0];
                string chapter = parts[1];
                string verse = parts[2];
                string verseEnd = parts[3];
                string text = parts[4];
            }
            else
            {
                Console.WriteLine($"Invalid line: {line}");
            }
        }

        // loop through the program until the user quits or the scritpure is completely hidden
        while (true)
        {
            // display the title of the program
            Console.WriteLine("Scripture Memorizer Program");
            // display the reference and the text
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            // get the user's input
            string userChoice = Console.ReadLine();

            //if (Console.ReadKey().Key == ConsoleKey.Enter)
            // if the user press enter, hide three words
            if (string.IsNullOrWhiteSpace(userChoice))
            {
                // clear the console
                Console.Clear();
                // if the scripture is completely hidden, break out of the loop and end the program
                if (scripture.IsCompletelyHidden() == true)
                {
                    break;
                }
                // if the scripture is not completely hidden, hide three words
                else 
                {
                    scripture.HideWords();
                    scripture.HideWords();
                    scripture.HideWords();
                }
            }
            // if the user types 'quit', break out of the loop and end the program
            else if (userChoice == "quit")
            {
                break;
            }
            // if the user types anything else, display an error message
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        
    }
}