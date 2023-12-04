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
        Console.WriteLine("1. Create a new task");
        Console.WriteLine("2. Display the to-do list");
        Console.WriteLine("3. Save the to-do list");
        Console.WriteLine("4. Load a to-do list");
        Console.WriteLine("5. Complete a task");
        Console.WriteLine("6. Quit");
    }

    /* GetUMenu is a method that gets the user's choice from the menu.
    Parameters: none
    Return: none
    */
    public void GetMenu()
    {
        int choice = 0;
        while (choice != 6)
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
                case 1: // tested : ok
                    taskManager.AddTask();
                    break;
                case 2: // tested : add feature to remove accomplished tasks, sort by due date, and display overdue tasks
                    _tasks = taskManager.GetTasks(); // update the list of tasks
                    taskManager.DisplayTasks();
                    break;
                case 3:  // tested : ok
                    taskManager.SaveTasks();
                    Console.WriteLine("To-Do list saved.");
                    break;
                case 4: // tested : ok
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    _tasks = taskManager.LoadTasks(filename); // update the list of tasks
                    Console.WriteLine("To-Do list loaded.");
                    break;
                case 5: // tested : ok (added feature to update due date to repetitive tasks)
                     _tasks = taskManager.GetTasks(); // update the list of tasks
                    DisplayTasks();
                    Console.Write("Which task have you accomplished? ");
                    int taskIndex = Convert.ToInt32(Console.ReadLine());
                    taskManager.CompleteTask(taskIndex, _tasks);
                    break;
                case 6: // tested : ok
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}