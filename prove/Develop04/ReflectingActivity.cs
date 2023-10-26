using System;

/* Reflecting Activity class */
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string nameActivity, string description) : base (nameActivity, description)
    {
        _nameActivity = nameActivity;
        _description = description;
    }
}