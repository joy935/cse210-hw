using System;

/* Simple Goal derived class */
public class SimpleGoal : Goal
{

    private bool _completed = false;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    { }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        return $"Simple Goal~{_name}~{_description}~{_points}";
    }

    public override void ListGoals()
    {
        if (IsCompleted() == true)
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override string GetStringRepresentation()
    {
        if (_completed == true)
        {
            return $"Simple Goal~{_name}~{_description}~{_points}~True";
        }
        else 
        {
            return $"Simple Goal~{_name}~{_description}~{_points}~False";
        }
    }

    public override bool IsCompleted()
    {
        if (_completed == true) // when known, this condition should be changed
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}