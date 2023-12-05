using System;

class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>(); // create a new list of tasks
        UserInterface userInterface = new UserInterface(tasks); // create a new object of the UserInterface class

        Console.Clear(); // clear the screen
        Console.WriteLine("Welcome to the To-Do List Application!"); // welcome message
        userInterface.GetMenu();
    }
}