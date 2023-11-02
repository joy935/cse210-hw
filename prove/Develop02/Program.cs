using System;
using System.IO; 

partial class Program
{
    static void Main(string[] args)
    {
        // welcome message to start the journal program
        Console.WriteLine("Welcome to the Journal Program!");

        // initialize the fileName with an existing file
        string fileName = "myFile.txt";
        
        // loop through the menu
        while (true)
        {
            /* five options for the menu: write an entry, 
            display the entry (or entries), load a particular file, 
            save a particular file and quit the menu and program */
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            /* get the choice of the user in choiceUser and convert it to 
            an integer */
            string choiceUser = Console.ReadLine();
            int choice = int.Parse(choiceUser);

            // get the current date of the entry and store it in dataText
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            // create the prompt, entry and journal objects
            Prompt prompt = new Prompt();
            Entry entry = new Entry();
            Journal journal = new Journal();

            // if the user chooses to write an entry 
            if (choice == 1)
            {
                /* get the class attribute _date from the entry object 
                to correspond to the dateText */
                entry._date = dateText;
                /* get the class attribute _randomPrompt from the entry 
                object to correspond to the method GetRandomPrompt from 
                the prompt object */
                entry._randomPrompt = prompt.GetRandomPrompt();
                // display the random prompt
                Console.WriteLine(entry._randomPrompt);
                Console.Write("> ");
                /* store the user entry in the class attribute _entry 
                from the entry object */
                entry._entry = Console.ReadLine();
                // add the new entries to list of the journal class
                journal._entries.Add(entry);
                /* add the user entry to a file using the method 
                WriteEntryInFile from the entry object */
                journal.WriteEntryInFile(fileName);            
            }
            // if the user chooses to display the entry (entries)
            else if (choice == 2)
            {
                /* display the entry (entries) using the method 
                DisplayEntryFromFile from the journal object */
                journal.DisplayEntry(fileName);

            }
            // if the user chooses to load a file
            else if (choice == 3)
            {
                /* load a file using the method LoadFile from the 
                journal object and store it as FileName */
                fileName = journal.LoadFile(); 
            }
            // if the user chooses to save the file
            else if (choice == 4)
            {
                /* save the file using the SaveFile method from the 
                journal object and store it as FileName */
                fileName = journal.SaveFile();
            }
            // if the user chooses to quit
            else if (choice == 5)
            {
                // break the while loop and end the program
                break;
            }
        }
    }
}