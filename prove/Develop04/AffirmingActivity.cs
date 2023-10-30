using System;

/* Affirmation class */
public class AffirmingActivity : Activity
{
    private List<string> _prompts = new List<string>
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
    }

    public AffirmingActivity(string nameActivity, string description, int duration) : base (nameActivity, description, duration)
    {
        _nameActivity = nameActivity;
        _description = description;
        _duration = duration;
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }

    public void DisplayOpeningMessage()
    {
        Console.WriteLine("Consider the following affirmation:\n");
        Console.Write("You may begin in: ");
        PauseCountdown();
    }

    public void DisplayPrompt()
    {
        string prompt = GetPrompt();
        Console.WriteLine(prompt);
    }
}