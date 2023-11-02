using System;

/* Eternal Goal derived class */
public class EternalGoal : Goal
{
    private int _totalPoints;

    public EternalGoal(string name, string description, int points, int totalPoints) : base(name, description, points)
    {
        _totalPoints = totalPoints;
    }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        return $"Eternal Goal~{_name}~{_description}~{points}";
    }
}