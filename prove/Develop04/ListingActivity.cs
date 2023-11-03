using System;

/* Listing Activity derived class */
public class ListingActivity : Activity
{
    // attribute of the class
    private List<string> _prompts = new List<string> // list of prompts
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    /* ListingActivity is a constructor method that creates an instance of the ListingActivity class
    by calling the constructor of the base class.
    Parameters: string nameActivity, string description, int duration
    Return: none
    */
    public ListingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    /* GetPrompt is a method that returns a random prompt from the list of prompts.
    Parameters: none
    Return: string, a random prompt
    */
    public string GetPrompt()
    {
        // create a list of indexes
        List <int> listIndexes = new List<int>();
        // create a random object
        Random random = new Random();
        // create a random index
        int randomIndex;
        // get a different random prompt from the list
        do 
        {
            randomIndex = random.Next(_prompts.Count);
        } while (listIndexes.Contains(randomIndex));
        // add the random index to the list
        listIndexes.Add(randomIndex);
        // return the random prompt
        return _prompts[randomIndex];
    }

    /* DisplayPrompt is a method that displays the prompt and 
    uses the PauseCountdown method to display the countdown.
    Parameters: none
    Return: none
    */
    public void DisplayPrompt()
    {
        // display the prompt
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.Write("You may begin in: ");
        // display the countdown
        PauseCountdown();
        Console.WriteLine("");
    }

    /* GetResponse is a method that gets the user's response and returns it.
    Parameters: none
    Return: string, the user's response
    */
    public string GetResponse()
    {
        Console.Write("> ");
        // get the user's response
        string input = Console.ReadLine();
        // return the user's response
        return input;
    }
}