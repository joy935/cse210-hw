using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness Program!");
        
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu.");
            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                break;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Starting reflecting activity...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Starting listening activity...");
            }
            else if (choice == 4)
            {
                break;
            }

        }
    }
}