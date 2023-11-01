using System;

/* Listing Activity class */
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    public string GetPrompt()
    {
        List <int> listIndexes = new List<int>();
        Random random = new Random();
        int randomIndex;
        do 
        {
            randomIndex = random.Next(_prompts.Count);
        } while (listIndexes.Contains(randomIndex));
        listIndexes.Add(randomIndex);
        return _prompts[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.Write("You may begin in: ");
        PauseCountdown();
        Console.WriteLine("");
    }

    public string GetResponse()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        return input;
    }
}