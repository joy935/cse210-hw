using System;

class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();
        UserInterface userInterface = new UserInterface(tasks);

        Console.Clear(); // clear the screen
        Console.WriteLine("Welcome to the To-Do List Application!"); // welcome message
        userInterface.GetMenu();
    }
}