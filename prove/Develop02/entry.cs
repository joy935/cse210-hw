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
        return $"{_date}~{_randomPrompt}~{_entry}";
    }
}