using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        LoadSaveGoal lsgoals = new LoadSaveGoal("filename");
        UserInterface userinterface = new UserInterface(goals);

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
                    SimpleGoal sGoal = new SimpleGoal("simple", "new", "description", 0, false);
                    sGoal.CreateGoal();
                    goals.Add(sGoal);
                }
                else if (goalType == 2)
                {   
                    EternalGoal eGoal = new EternalGoal("eternal", "new", "description", 0);
                    eGoal.CreateGoal();
                    goals.Add(eGoal);
                }
                else if (goalType == 3)
                {   
                    ChecklistGoal cGoal = new ChecklistGoal("checklist", "new", "description", 0, 0, 0, 0);
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
                string fileName = Console.ReadLine();
                lsgoals.SaveGoal(fileName, goals);

            }
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                goals = lsgoals.LoadGoal(fileName);
            }
            else if (choice == 5)
            {
                Console.WriteLine("The goals are: ");
                int i = 1;
                foreach (Goal goal in goals)
                {
                    Console.Write($"{i}. ");
                    goal.ListGoals();
                    Console.WriteLine(goal);
                    i++;
                }
                Console.Write("Which goal did you accomplish? ");
                int goalDone = int.Parse(Console.ReadLine()) - 1;
                // foreach (Goal goal in goals)
                // {
                //     userinterface.UpdateGoal(goalDone);
                // }
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