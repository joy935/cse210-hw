using System;

/* Checklist Goal derived class */
public class ChecklistGoal : Goal
{
    private int _totalPoints;
    private int _totalRepetition;
    private int _bonus;
    private int _completed;

    public ChecklistGoal(string name, string description, int points, int totalPoints, int bonus, int totalRepetition, int completed) : base(name, description, points)
    {
        _totalPoints = totalPoints;
        _bonus = bonus;
        _totalRepetition = totalRepetition;
        _completed = completed;
    }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int totalRepetition = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus accomplishing it that many times? ");
        int bonus = Convert.ToInt32(Console.ReadLine());
        int completed = 0;
        return $"Checklist Goal~{name}~{description}~{points}~{bonus}~{totalRepetition}~{completed}";
    }
}