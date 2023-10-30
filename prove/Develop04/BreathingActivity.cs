using System;

/* BreathingActivity class */
public class BreathingActivity : Activity
{
    public BreathingActivity(string nameActivity, string description) : base (nameActivity, description)
    {
        _nameActivity = nameActivity;
        _description = description;
    }

    public void DisplayBreathe()
    {
        Console.Write("Breathe in...");
        PauseCountdown();
        Console.WriteLine("");
        Console.Write("Now, breathe out...");
        PauseCountdown();
        Console.WriteLine("");
    }
}