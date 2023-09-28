using System;
using System.IO; 

// create a class
public class Entry
{
    // define class attributes
    public string _randomPrompt; // for the random prompts
    public string _entry;        // for the user entry
    public string _date;         // for the date of the entry

    /* WriteEntryInFile is a method that writes the new entry 
    in the file composed by the date, the random prompt and the 
    user entry.
    Parameter: filename, the name of the file 
    Return : nothing */
    public void WriteEntryInFile(string fileName)
    {
        // open, write and close the file
        // true is to append the file (otherwise it would overwrite)
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // the entry is composed by the date, the prompt and the entry
            outputFile.WriteLine($"Date: {_date} - Prompt: {_randomPrompt}\n{_entry}\n");
        }
    }
}