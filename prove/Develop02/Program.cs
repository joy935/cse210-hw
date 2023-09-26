using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("2. Quit");
            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);    
        }
    }
}