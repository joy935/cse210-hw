using System;
using System.IO; 

    // define a class
    public class Journal
    {
        // define a list of entries from the entry class
        public List<Entry> _entries;

        /* DisplayEntryFromFile is a method that display each entry
        from a file. 
        Parameter: filename, the name of the file 
        Return: nothing */
        public void DisplayEntry()
        {
            // Streak streak = new Streak();
            // streak.GetTheDates(filename);
            // int currentStreak = streak.GetInfoDates();
            // Console.WriteLine($"Streak: {currentStreak}");

            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.GetEntry());
            }
        }

        /* Load the journal from a file
        Parameter: none
        Return: filename, the name of the file*/
        public List<Entry> LoadFile(string filename)
        {
            string [] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string [] parts = line.Split('~');

                string date = parts[0].Trim();
                string prompt = parts[1].Trim();
                string entry = parts[2].Trim();   
            }
            return _entries;
        }

        /* Save the journal to a file
        Parameter: none
        Return: filename, the name of the file */
        public void SaveFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                // iterate through all entries
                foreach (Entry entry in _entries)
                {
                    // write each entry in the file
                    outputFile.WriteLine(entry.GetInfo());
                }
            };

            // determine the path to save the file
            string firstPartPath = "./prove/Develop02/";
            string filePath = Path.Combine(firstPartPath, filename);
        }
    }