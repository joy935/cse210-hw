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
}