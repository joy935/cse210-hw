using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");

        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string choiceUser = Console.ReadLine();
        int choice = int.Parse(choiceUser);

        if (choice == 1)
        {
            Console.WriteLine("1");
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            
            Prompt prompt = new Prompt();
            Entry entry = new Entry();
            entry._date = dateText;
            entry._randomPrompt = prompt.GetRandomPrompt();
            Console.WriteLine(entry._randomPrompt);
            Console.Write("> ");
            entry._entry = Console.ReadLine();
            entry.DisplayEntry();
        }
        else if (choice == 2)
        {
            Console.WriteLine("2");
        }
        else if (choice == 3)
        {
            Console.WriteLine("3");
        }
        else if (choice == 4)
        {
            Console.WriteLine("4");
        }
        // else if (choice == 5)
        // {
        //     Console.WriteLine("5");
        // }
    }
}