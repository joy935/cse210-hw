using System;
using System.IO; 

    // define a class
    public class Journal
    {
        // define a list of entries from the entry class
        public List<Entry> _entries = new List<Entry>();

        /* AddEntryInFile is a method that writes the new entry 
        composed by the date, the random prompt and the 
        user entry in a file.
        Parameter: fileName
        Return: nothing */
        public void WriteEntryInFile(string filename)
        {
            // open, write and close the file
            // true, to append the file (otherwise it would overwrite)
            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                // iterate through all entries
                foreach (Entry entry in _entries)
                {
                    // write each entry in the file
                    outputFile.WriteLine(entry.GetEntry());
                }
            }
        }

        /* DisplayEntryFromFile is a method that display each entry
        from a file. 
        Parameter: filename, the name of the file 
        Return: nothing */
        public void DisplayEntryFromFile(string filename)
        {
            // if the file exists, display the content of the file
            if (File.Exists(filename))
            {
                //
                Streak streak = new Streak();
                streak.GetTheDates(filename);
                int currentStreak = streak.GetInfoDates();
                Console.WriteLine($"Streak: {currentStreak}");

                /* open a file, read all lines of the file into the string array 
                lines and close the file */
                string[] lines = System.IO.File.ReadAllLines(filename);

                // iterate through all lines in the file
                foreach (string line in lines)
                {
                    // split each line at the tilde character
                    string[] elements = line.Split("~");

                    // if there are all the elements (date, prompt and entry)
                    if (elements.Length >= 3)
                    {
                        // create three strings to correspond to a specific element
                        string date = elements[0];
                        string prompt = elements[1];
                        string entry = elements[2];
                        // display each line
                        Console.WriteLine($"Date: {date} - Prompt: {prompt}\n{entry}\n");
                    }
                    // if the line doesn't have enough element
                    else
                    {
                        // display this error message
                        Console.WriteLine($"Invalid format of the entry: {line}.");
                    }
                }
            }
            // if the file doesn't exist, display an error message
            else
            {
                /* display the error message with the name of the 
                file not found */
                Console.WriteLine($"File '{filename}' not found.");
            }
        }

        /* Load the journal from a file
        Parameter: none
        Return: filename, the name of the file*/
        public string LoadFile()
        {
            // get the filename from the user
           Console.WriteLine("What is the filename?");
           string filename = Console.ReadLine();
           return filename;

        }

        /* Save the journal to a file
        Parameter: none
        Return: filename, the name of the file */
        public string SaveFile()
        {
            // get the filename from the user
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();

            // determine the path to save the file
            string firstPartPath = "/Users/veihitupai/Documents/GitHub/cse210-hw/prove/Develop02/";
            string filePath = Path.Combine(firstPartPath, filename);
            
            // concatenate the entries of the journal 
            string entriesToAdd = string.Join(Environment.NewLine, _entries);
            
            // create a new file, write the journal to the file and close the file
            // if the file already exists, overwrite it
            System.IO.File.WriteAllText(filePath, entriesToAdd);
            return filename;
        }
    }

