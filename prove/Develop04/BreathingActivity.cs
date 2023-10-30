using System;

/* BreathingActivity class */
public class BreathingActivity : Activity
{
    public BreathingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    public void DisplayBreathe()
    {
        Console.Write("\nBreathe in...");
        PauseCountdown();
        Console.WriteLine("");
        Console.Write("Now, breathe out...");
        PauseCountdown();
        Console.WriteLine("");
    }
}