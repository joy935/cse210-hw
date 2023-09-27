using System;
using System.IO; 

public class Entry
{
    public string _randomPrompt;
    public string _entry;
    public string _date;

    public void WriteEntryInFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"Date:{_date} - Prompt:{_randomPrompt}\n{_entry}\n");
        }
    }
}