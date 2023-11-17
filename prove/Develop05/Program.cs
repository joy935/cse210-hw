using System;

class Program
{
    static void Main(string[] args)
    {
    
        List<Goal> goals = new List<Goal>();                    // Create a list of Goal objects
        LoadSaveGoal lsGoals = new LoadSaveGoal("filename");    // Create a LoadSaveGoal object
        UserInterface userInterface = new UserInterface(goals); // Create a UserInterface object
        int totalPoints = 0;                                    // Create a totalPoints variable and set the value to 0
        Game game = new Game(totalPoints);                      // Create a Game object

        // Display the menu options and loop until the user chooses to quit
        while (true)
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create a new Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
        
            int choice = int.Parse(Console.ReadLine()); // Get the user's choice and convert it to an integer

            // if the user chooses to create a new goal
            if (choice == 1)
            {
                // Display the goal types options
                Console.WriteLine("The type of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");

                int goalType = int.Parse(Console.ReadLine()); // Get the user's choice and convert it to an integer

                // if the user chooses to create a simple goal
                if (goalType == 1)
                {
                    // create a new simple goal object
                    SimpleGoal sGoal = new SimpleGoal("simple", "new", "description", 0, false);
                    // call the CreateGoal method
                    sGoal.CreateGoal();
                    // add the goal to the list of goals
                    goals.Add(sGoal);
                }
                // if the user chooses to create an eternal goal
                else if (goalType == 2)
                {   
                    EternalGoal eGoal = new EternalGoal("eternal", "new", "description", 0);
                    eGoal.CreateGoal();
                    goals.Add(eGoal);
                }
                // if the user chooses to create a checklist goal
                else if (goalType == 3)
                {   
                    ChecklistGoal cGoal = new ChecklistGoal("checklist", "new", "description", 0, 0, 0, 0);
                    cGoal.CreateGoal();
                    goals.Add(cGoal);
                }
                // if the user chooses an invalid option
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            // if the user chooses to list the goals
            else if (choice == 2)
            {
                Console.WriteLine("The goals are: ");
                int i = 1; // create a counter variable
                // loop through the list of goals and display them
                foreach (Goal goal in goals)
                {
                    Console.Write($"{i}. ");
                    goal.ListGoals();
                    i++;
                }
                // display the current level
                game.DisplayLevel();
            }
            // if the user chooses to save the goals
            else if (choice == 3) // save goals
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();   // get the filename from the user
                lsGoals.SaveGoal(fileName, goals);      // call the SaveGoal method

            }
            // if the user chooses to load the goals
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();   // get the filename from the user
                goals = lsGoals.LoadGoal(fileName);     // call the LoadGoal method
                totalPoints = lsGoals.GetTotalPoints(); // get the total points from the file
            }
            // if the user chooses to record an event
            else if (choice == 5)
            {
                // display the goals
                Console.WriteLine("The goals are: ");
                int i = 1;
                foreach (Goal goal in goals)
                {
                    Console.Write($"{i}. ");
                    goal.ListGoals();
                    i++;
                }
                Console.Write("Which goal did you accomplish? ");       
                int goalDone = int.Parse(Console.ReadLine()) - 1;       // get the goal completed from the user and convert it to an integer
                int points = userInterface.UpdateGoal(goalDone, goals); // call the UpdateGoal method
                totalPoints += points;                                  // add the points to the total points
                lsGoals.SetTotalPoints(totalPoints);                    // set the total points in the file
                game.SetTotalPoints(totalPoints);                       // set the total points in the game object
                game.LevelUp();                                         // call the LevelUp method
            }
            // if the user chooses to quit
            else if (choice == 6)
            {
                // break the loop
                break;
            }
            // if the user chooses an invalid option
            else 
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}