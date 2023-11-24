using System;

/* User Interface Class */
class UserInterface 
{

    /* attribute of the class */
    // list of tasks ???

    List<Task> tasks = new List<Task>(); // where to put this? in the constructor?
    /* constructor of the class */
    public UserInterface() 
    {
    }

    /* Menu is a method that displays the menu options.
    Parameters: none
    Return: none
    */
    public void Menu()
    {
        Console.WriteLine("Menu:");
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
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Create a new task");
                    break;
                case 2:
                    Console.WriteLine("Display the to-do list");
                    DisplayTasks();
                    break;
                case 3:
                    Console.WriteLine("Save the to-do list");
                    break;
                case 4:
                    Console.WriteLine("Load a to-do list");
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
    Parameters: List<Task> _tasks, the list of tasks
    Return: none
    */
    public void DisplayTasks()
    {
        Console.WriteLine("To-do list");
        foreach (Task task in tasks)
        {
            task.DisplayTaskInfo();
        }
    }
}