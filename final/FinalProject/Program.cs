using System;

class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();
        UserInterface userInterface = new UserInterface();

        userInterface.GetMenu();
    }
}