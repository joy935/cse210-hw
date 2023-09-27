using System;
using System.IO; 

    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        // public void AddEntry()
        // {
        //     using  (StreamWriter outputFile = new StreamWriter(fileName))
        //     {
        //         outputFile.WriteLine($"{date} - {prompt}");
        //     }
        // }
        // public void Display()
        // {
        //     string fileName = "";
        //     string[] lines = System.IO.File.ReadAllLines(fileName);
        //     foreach (Entry entry in _entries)
        //     {
        //         entry.DisplayEntry();
        //     }
        // }
        public void SaveFile()
        {
            ///
        }
        // public void LoadFile()
        // {
        //     ///
        // }
    }