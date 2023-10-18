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
        // create a random object
        Random random = new Random();
        // create a scripture object and initialize it to null
        Scripture scripture = null;
        // get a random index from the lines array
        int randomIndex = random.Next(0, lines.Length);
        
        // loop through the lines array
        foreach (string line in lines)
        {
            // create a string variable and initialize it to the line at the random index
            string chosenLine = lines[randomIndex];
            // split the line into an array of strings at the ~ character
            string [] parts = chosenLine.Split("~");

            // if the length of the array is 4, create a scripture object with 4 parameters
            if (parts.Length == 4)
            {
                // create variables for each part of the array
                string book = parts[0];
                string chapter = parts[1];
                string verse = parts[2];
                string text = parts[3];
                // create a new scripture object for a verse
                scripture = new Scripture(book, chapter, verse, text);
            }
            // if the length of the array is 5, create a scripture object with 5 parameters
            else if (parts.Length == 5)
            {
                // create variables for each part of the array
                string book = parts[0];
                string chapter = parts[1];
                string verse = parts[2];
                string verseEnd = parts[3];
                string text = parts[4];
                // create a new scripture object for multiple verses
                scripture = new Scripture(book, chapter, verse, verseEnd, text);
            }
            // if the length of the array is different from 4 or 5
            else
            {
                // display an error message
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