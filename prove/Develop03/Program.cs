using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Scripture Memorizer Program");
            Console.WriteLine("display ref and vers");
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