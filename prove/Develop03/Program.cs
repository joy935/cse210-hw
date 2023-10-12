using System;

class Program
{
    static void Main(string[] args)
    {
        //Scripture scripture = new Scripture();
        Reference reference = new Reference();
        //Word word = new Word();

        while (true)
        {
            Console.WriteLine("Scripture Memorizer Program");

            Console.WriteLine($"{reference.DisplayReference()} {reference.DisplayText()}");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            string userChoice = Console.ReadLine();

            if (userChoice == "quit")
            {
                break;
            }
            else if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
        
    }
}