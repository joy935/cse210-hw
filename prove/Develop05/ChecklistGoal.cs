using System;

/* Checklist Goal derived class */
public class ChecklistGoal : Goal
{
    private int _totalRepetition;
    private int _bonus;
    private int _completed;

    public ChecklistGoal(string name, string description, int points, int bonus, int totalRepetition, int completed) : base(name, description, points)
    {
        _bonus = bonus;
        _totalRepetition = totalRepetition;
        _completed = completed;
    }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _totalRepetition = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus accomplishing it that many times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());
        _completed = 0;
        return $"Checklist Goal~{_name}~{_description}~{_points}~{_bonus}~{_totalRepetition}~{_completed}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal~{_name}~{_description}~{_points}~{_bonus}~{_totalRepetition}~{_completed}";
    }

    public override void ListGoals()
    {
        Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: {_completed}/{_totalRepetition}");
    }
    
}