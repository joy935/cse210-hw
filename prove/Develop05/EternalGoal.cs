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
}