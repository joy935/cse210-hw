using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");

        string fileName = "myFile.txt";

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Prompt prompt = new Prompt();
            Entry entry = new Entry();
            Journal journal = new Journal();

            if (choice == 1)
            {
                entry._date = dateText;
                entry._randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(entry._randomPrompt);
                Console.Write("> ");
                entry._entry = Console.ReadLine();
                entry.WriteEntryInFile(fileName);            
            }
            else if (choice == 2)
            {
                journal.DisplayEntryFromFile(fileName);

            }
            else if (choice == 3)
            {
                fileName = journal.LoadFile();
            }
            else if (choice == 4)
            {
                fileName = journal.SaveFile();
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
}