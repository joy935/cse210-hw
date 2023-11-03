using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

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

                if (goalType == 1)
                {
                    SimpleGoal sGoal = new SimpleGoal("simple", "description", 0);
                    sGoal.CreateGoal();
                    goals.Add(sGoal);
                }
                else if (goalType == 2)
                {   
                    EternalGoal eGoal = new EternalGoal("eternal", "description", 0);
                    eGoal.CreateGoal();
                    goals.Add(eGoal);
                }
                else if (goalType == 3)
                {   
                    ChecklistGoal cGoal = new ChecklistGoal("checklist", "description", 0, 0, 0, 0);
                    cGoal.CreateGoal();
                    goals.Add(cGoal);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are: ");
                int i = 1;
                foreach (Goal goal in goals)
                {
                    Console.Write($"{i}. ");
                    goal.ListGoals();
                    i++;
                }
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename, true))
                {
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                };
                string firstPath = "./prove/Develop05/";
                string filePath = Path.Combine(firstPath, filename);
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