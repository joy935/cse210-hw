using System;
using System.IO; 

    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntryInFile()
        {
            foreach (Entry entry in _entries)
            {
                entry.WriteEntryInFile();
            }
        }

        public void DisplayEntryFromFile()
        {
            string fileName = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public void SaveFile()
        {
            ///
        }
        // public void LoadFile()
        // {
        //     ///
        // }
    }