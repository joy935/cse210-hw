using System;

/* Simple Goal derived class */
public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    { }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        return $"Simple Goal~{_name}~{_description}~{points}";
    }

    public override string DisplayGoal()
    {
        return $"Simple Goal~{_name}~{_description}~{points}";
    }
}