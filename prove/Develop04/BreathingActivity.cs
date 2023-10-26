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
        Console.WriteLine("Breathe in...");
        PauseCountdown();
        Console.WriteLine("Now, breathe out...\n");
        PauseCountdown();
    }
}