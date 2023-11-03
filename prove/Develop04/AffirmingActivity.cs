using System;

/* Affirmation derived class */
public class AffirmingActivity : Activity
{
    // attribute of the class
    private List<string> _affirmations = new List<string> // list of affirmations
    {
        "I feel surrounded by love everywhere.",
        "I am a person of faith, and I believe that good things lie ahead of me!",
        "I give myself permission to do what is right for me.",
        "I forgive those who have harmed me in my past and peacefully detach from them.",
        "I deserve to be happy and loved.",
        "I give myself space to grow and learn.",
        "I put my energy into things that matter to me.",
        "My drive and ambition allow me to achieve my goals.",
        "I accomplish everything I set my mind to.",
        "Counting our blessings is far better than recounting our problems.",
    };

    /* AffirmingActivity is a constructor method that creates an instance of the AffirmingActivity class
    by calling the constructor of the base class.
    Parameters: string nameActivity, string description, int duration
    Return: none
    */
    public AffirmingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    /* GetPrompt is a method that returns a random affirmation from the list of affirmations.
    Parameters: none
    Return: string, a random affirmation
    */
    public string GetPrompt()
    {
        // create a random object
        Random random = new Random();
        // get a random affirmation from the list
        int i = random.Next(_affirmations.Count);
        // return the random affirmation
        return _affirmations[i];
    }

    /* DisplayOpeningMessage is a method that displays the opening message 
    of the affirming activity and uses the PauseCountdown method to display 
    the countdown.
    Parameters: none
    Return: none
    */
    public void DisplayOpeningMessage()
    {
        Console.WriteLine("\nConsider the following affirmation:\n");
        Console.Write("You may begin in: ");
        PauseCountdown();
        Console.WriteLine("");
    }

    /* DisplayAffirmation is a method that displays the affirmation
    and uses the PauseSpinner method to display the spinner after
    each affirmation.
    */
    public void DisplayAffirmation()
    {
        // get a random affirmation
        string prompt = GetPrompt();
        // display the affirmation
        Console.Write($"{prompt}");
        PauseSpinner();
        Console.WriteLine("");
    }
}