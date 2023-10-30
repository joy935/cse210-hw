using System;

/* Reflecting Activity class */
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string nameActivity, string description) : base (nameActivity, description)
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

    public string GetQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        return _questions[i];
    }

    public string DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetPrompt()} ---\n");
        Console.Write("When you have something in mind, press enter to continue.");
        string ready = Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("");
        Console.Write("You may begin in: ");
        PauseCountdown();
        Console.Clear();
        return ready;
    }

    public void DisplayQuestion()
    {
        string question = GetQuestion();
        Console.Write($"> {question}");
        PauseSpinner();
        Console.WriteLine("");
    }
}