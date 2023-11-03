using System;

/* Eternal Goal derived class */
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        return $"Eternal Goal~{_name}~{_description}~{_points}";
    }

    public override void ListGoals()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal~{_name}~{_description}~{_points}";
    }
}