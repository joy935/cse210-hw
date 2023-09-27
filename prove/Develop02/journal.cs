using System;
using System.IO; 

    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntryInFile(string fileName)
        {
            foreach (Entry entry in _entries)
            {
                entry.WriteEntryInFile(fileName);
            }
        }

        public void DisplayEntryFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"File '{filename}' not found.");
            }
        }

        public string LoadFile()
        {
           Console.WriteLine("What is the filename?");
           string filename = Console.ReadLine();
           return filename;

        }

        public string SaveFile()
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();

            string firstPartPath = "/Users/veihitupai/Documents/GitHub/cse210-hw/prove/Develop02/";
            string filePath = Path.Combine(firstPartPath, filename); 
            
            string entriesToAdd = string.Join(Environment.NewLine, _entries);
            System.IO.File.WriteAllText(filePath, entriesToAdd);
            return filename;
        }
    }