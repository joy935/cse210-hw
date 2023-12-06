using System;

/* User Interface Class */
class UserInterface 
{

    /* attribute of the class */
    private List<Task> _tasks; // list of tasks

    /* constructor of the class */
    public UserInterface(List<Task> tasks)
    {
        _tasks = tasks;
    }

    /* methods of the class */
    /* Menu is a method that displays the menu options.
    Parameters: none
    Return: none
    */
    public void Menu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Create a new simple task");
        Console.WriteLine("2. Create a new scheduled task");
        Console.WriteLine("3. Create a new repetitive task");
        Console.WriteLine("4. Display the to-do list");
        Console.WriteLine("5. Save the to-do list");
        Console.WriteLine("6. Load a to-do list");
        Console.WriteLine("7. Complete a task");
        Console.WriteLine("8. Display the accomplished tasks");
        Console.WriteLine("9. Quit");
    }

    /* GetUMenu is a method that gets the user's choice from the menu.
    Parameters: none
    Return: none
    */
    public void GetMenu()
    {
        int choice = 0;
        while (choice != 9)
        {
            // display the menu
            Menu();
            // get the user's choice and convert it to an integer
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            // create a task manager object
            TaskManager taskManager = new TaskManager("tasks.txt", _tasks);

            switch (choice)
            {
                case 1:
                    taskManager.AddSimpleTask();
                    break;
                case 2:
                    taskManager.AddScheduledTask();
                    break;
                case 3:
                    taskManager.AddRepetitiveTask();
                    break;
                case 4:
                    _tasks = taskManager.GetTasks(); // update the list of tasks
                    taskManager.DisplayTasks();
                    break;
                case 5:
                    taskManager.SaveTasks();
                    Console.WriteLine("To-Do list saved.");
                    break;
                case 6:
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    _tasks = taskManager.LoadTasks(filename); // update the list of tasks
                    Console.WriteLine("To-Do list loaded.");
                    break;
                case 7:
                     _tasks = taskManager.GetTasks(); // update the list of tasks
                    taskManager.DisplayAllTasks();
                    Console.Write("Which task have you accomplished? ");
                    int taskIndex = Convert.ToInt32(Console.ReadLine());
                    taskManager.CompleteTask(taskIndex, _tasks);
                    break;
                case 8:
                    Console.WriteLine();
                    taskManager.DisplayAccomplishedTasks();
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}