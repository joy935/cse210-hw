using System;
using System.Diagnostics.Tracing;

/* Simple Goal derived class */
public class SimpleGoal : Goal
{

    private bool _completed; // to store the completion status of the goal
    
    // constructor to initialize the fields of the class using the base class constructor
    public SimpleGoal(string type, string name, string description, int points, bool completed) : base(type, name, description, points)
    {
        _completed = completed;
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
            return $"SimpleGoal:{_name}~{_description}~{_points}~True";
        }
        else 
        {
            return $"SimpleGoal:{_name}~{_description}~{_points}~False";
        }
    }

    public override bool IsCompleted()
    {
        if (_completed == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _completed = true;
        GetStringRepresentation();
        return _points;
    }
}