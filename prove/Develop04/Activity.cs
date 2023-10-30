using System;

/* Activity class */
public class Activity
{
    protected string _nameActivity;
    protected string _description;
    protected int _duration;

    public string DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameActivity}!\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        return duration;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.Write("Get ready...");
        PauseSpinner();
    }

    public void PauseSpinner()
    {
        string [] spinCharacters = new string [] {"|", "/", "-", "\\"};
        for (int i = 0; i < 2; i++)
        {
            foreach (string spin in spinCharacters)
            {
                Console.Write(spin);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void PauseCountdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndMessage()
    {
        Console.Write($"\nWell done!!!");
        PauseSpinner();
        Console.WriteLine("");
        Console.Write($"\nYou have completed {_duration} seconds of the {_nameActivity}.");
        PauseSpinner();
    }

    public Activity(string nameActivity, string description)
    {
        _nameActivity = nameActivity;
        _description = description;
    }
    public string NameActivity
    {
        get { return _nameActivity; }
        set { _nameActivity = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

}