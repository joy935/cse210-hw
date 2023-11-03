using System;

/* Activity base class */
public class Activity
{
    // attributes of the class
    protected string _nameActivity; // name of the activity
    protected string _description;  // description of the activity
    protected int _duration;        // duration of the activity

    /*DisplayStartMessage is a method that displays the start message 
    for the activity and returns the duration of the activity as a string.
    Parameters: none
    Return: string, the duration of the activity specified by the user
    */
    public string DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameActivity}!\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        return duration;
    }

    /* GetReady is a method that displays the get ready message for the activity
    and use the PauseSpinner method to display a spinner.
    Parameters: none
    Return: none
    */
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();
    }

    /* PauseSpinner is a method that displays a spinner.
    Parameters: none
    Return: none
    */
    public void PauseSpinner()
    {
        // create an array of strings to hold the characters for the spinner
        string [] spinCharacters = new string [] {"|", "/", "-", "\\"};
        // loop through the array of strings twice
        for (int i = 0; i < 2; i++)
        {
            // loop through the array of strings
            foreach (string spin in spinCharacters)
            {
                // display the spinner
                Console.Write(spin);
                // pause for 500 milliseconds
                Thread.Sleep(500);
                // erase the spinner
                Console.Write("\b \b");
            }
        }
    }

    /* PauseCountdown is a method that displays a countdown.
    Parameters: none
    Return: none
    */
    public void PauseCountdown()
    {
        // loop through the countdown, starting at 3 and ending at 1
        for (int i = 3; i > 0; i--)
        {
            // display the countdown
            Console.Write($"{i}");
            // pause for 1 second
            Thread.Sleep(1000);
            // erase the countdown
            Console.Write("\b \b");
        }
    }

    /* DisplayEndMessage is a method that displays the end message for the activity
    and use the PauseSpinner method to display a spinner.
    Parameters: none
    Return: none
    */
    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nWell done!!!");
        // display the spinner
        PauseSpinner();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_nameActivity}.");
        // display the spinner
        PauseSpinner();
    }
    
    /* Activity is a constructor method that creates an instance of the Activity class.
    Parameters: string nameActivity, string description, int duration
    Return: none
    */
    public Activity(string nameActivity, string description, int duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    /* NameActivity is a property that gets and sets the name of the activity.
    Parameters: none
    Return: string, the name of the activity
    */
    public string NameActivity
    {
        get { return _nameActivity; }
        set { _nameActivity = value; }
    }

    /* Description is a property that gets and sets the description of the activity.
    Parameters: none
    Return: string, the description of the activity
    */
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    /* Duration is a property that gets and sets the duration of the activity.
    Parameters: none
    Return: int, the duration of the activity
    */
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

}