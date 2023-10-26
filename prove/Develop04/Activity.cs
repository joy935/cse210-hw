using System;

/* Activity class */
public class Activity
{
    protected string _nameActivity;
    protected string _description;
    protected int _duration;

    public string DisplayStartMessage( string nameActivity, string description)
    {
        return $"Welcome to the {nameActivity}!\n\n{description}\n\nHow long, in seconds, would you like for your session?";
    }

    public void PauseSpinner()
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
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
        Console.Write("0");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    public string DisplayEndMessage(string duration)
    {
        return $"Well done!!!\n\nYou have completed {duration} seconds of the {nameActivity}.";
    }

    public void Activity(string nameActivity, string description, int duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }
}