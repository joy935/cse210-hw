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
            Menu();
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            TaskManager taskManager = new TaskManager("tasks.txt", _tasks);

            switch (choice)
            {
                case 1: // tested : ok
                    taskManager.AddTask();
                    break;
                case 2: // tested : add numerotation to the tasks, display from a file
                    taskManager.DisplayTasks();
                    break;
                case 3:  // tested : ok
                    taskManager.SaveTasks();
                    Console.WriteLine("To-Do list saved.");
                    break;
                case 4: // tested : not ok
                    taskManager.LoadTasks();
                    Console.WriteLine("To-Do list loaded.");
                    break;
                case 5:
                    Console.WriteLine("Complete a task");
                    break;
                case 6:
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    /* DisplayTasks is a method that displays the tasks in a list format.
    Parameters: None
    Return: none
    */
    // public void DisplayTasks()
    // {
    //     Console.WriteLine("To-do list: ");
    //     foreach (Task task in _tasks)   // for each task in the list of tasks
    //     {
    //         task.DisplayTaskInfo();     // display the task info
    //     }
    // }
}