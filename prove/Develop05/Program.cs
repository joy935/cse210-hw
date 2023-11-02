using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("\nYou have ... points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create a new Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("The type of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                Goal goal = new Goal("one", "two", 2);
                Console.WriteLine($"{goal.CreateGoal()}");
                break;
            }
            else if (choice == 2)
            {
                Console.WriteLine("2");
            }
            else if (choice == 3)
            {
                Console.WriteLine("3");
            }
            else if (choice == 4)
            {
                Console.WriteLine("4");
            }
            else if (choice == 5)
            {
                Console.WriteLine("5");
            }
            else if (choice == 6)
            {
                break;
            }
            else 
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        
        
    }
}