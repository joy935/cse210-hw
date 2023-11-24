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

    /* DisplayMenu
    */
    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create a new task");
        Console.WriteLine("2. Display the to-do list");
        Console.WriteLine("3. Save the to-do list");
        Console.WriteLine("4. Load a to-do list");
        Console.WriteLine("5. Complete a task");
        Console.WriteLine("6. Quit");
    }

    /* GetUserInput
    */
    public void GetUserInput()
    {
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Create a new task");
                break;
            case 2:
                Console.WriteLine("Display the to-do list");
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

    /* DisplayTasks
    */
}