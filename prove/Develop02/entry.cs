using System;
using System.IO; 

public class Entry
{
    public string _randomPrompt;
    public string _entry;
    public string _date;

    public void WriteEntryInFile()
    {

        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"{_date} - {_randomPrompt}");
            outputFile.WriteLine(_entry);
        }
    }
}