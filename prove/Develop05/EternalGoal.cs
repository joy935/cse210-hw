using System;

/* Eternal Goal derived class */
public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    { }

    public override void ListGoals()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}~{_description}~{_points}";
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        GetStringRepresentation();
    }
}