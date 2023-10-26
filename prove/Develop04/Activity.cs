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
        Console.WriteLine("Get ready...");
        PauseSpinner();
    }

    public void PauseSpinner()
    {
        Console.Write("|");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Console.Write("\n");
    }

    public void PauseCountdown()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!!!");
        PauseSpinner();
        Console.WriteLine("\n");
        Console.WriteLine($"You have completed {_duration} seconds of the {_nameActivity}.");
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