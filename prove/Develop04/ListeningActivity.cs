using System;

/* Listening Activity class */
public class ListeningActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListeningActivity(string nameActivity, string description) : base (nameActivity, description)
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


}