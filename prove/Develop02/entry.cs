using System;
using System.IO; 
using System.Text;

// create a class
public class Entry
{
    // define class attributes
    public string _randomPrompt; // for the random prompts
    public string _entry;        // for the user entry
    public string _date;         // for the date of the entry

    /* WriteEntryInFile is a method that stores the new entry 
    composed by the date, the random prompt and the user entry 
    as a string.
    Parameter: none
    Return : the string composed by the date, prompt and entry. */
    public string GetEntry()
    {
        /* save the date, the prompt and the entry separated by a 
        tilde character as a string and return it*/
        return $"Date: {_date} - Prompt: {_randomPrompt}\n{_entry}";
    }

    public string GetInfo()
    {
        return $"{_date}~{_randomPrompt}~{_entry}";
    }

    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _randomPrompt = prompt;
        _entry = entry;
    }
}