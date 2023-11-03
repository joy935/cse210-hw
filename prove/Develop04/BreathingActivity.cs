using System;

/* BreathingActivity derived class */
public class BreathingActivity : Activity
{
    /* BreathingActivity is a constructor method that creates an instance of the BreathingActivity class
    by calling the constructor of the base class.
    Parameters: string nameActivity, string description, int duration
    Return: none
    */
    public BreathingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    /* DisplayBreathe is a method that displays the breathe in and breathe out messages
    and uses the PauseCountdown method to display the countdown.
    Parameters: none
    Return: none
    */
    public void DisplayBreathe()
    {
        // display the breathe in message
        Console.Write("\nBreathe in...");
        // display the countdown
        PauseCountdown();
        Console.WriteLine("");
        // display the breathe out message
        Console.Write("Now, breathe out...");
        // display the countdown
        PauseCountdown();
        Console.WriteLine("");
    }
}