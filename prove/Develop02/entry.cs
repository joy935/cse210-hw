using System;

public class Entry
{
    public string _randomPrompt;
    public string _entry;
    public string _date;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_randomPrompt}");
        Console.WriteLine(_entry);
    }
}