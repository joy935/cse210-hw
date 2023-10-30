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

    public ListingActivity(string nameActivity, string description) : base (nameActivity, description)
    {
        _nameActivity = nameActivity;
        _description = description;
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
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
        int i = 0;
        do 
        {
            Console.Write("> ");
            Console.Write("");
            Console.ReadLine();
            i++;
        }
        while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        return $"You listed {i} items.";

    }
}