using System;

/* Eternal Goal derived class */
public class EternalGoal : Goal
{
    /* EternalGoal is a constructor method used to initialize the fields of the class using the base class constructor
    Parameters: string type, string name, string description, int points
    Return: none
    */
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    { }

    /* ListGoals is a method that displays the goal in a list format
    It overrides the ListGoals method in the base class by adding a
    checkbox that is always empty to indicate that an eternal goal 
    can't be completed
    Parameters: none
    Return: none
    */
    public override void ListGoals()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    /* GetStringRepresentation is a method that returns a string
    representation of the goal
    It overrides the GetStringRepresentation method in the base class
    by displaying the goal type, name, description, and points 
    attributes
    Parameters: none
    Return: string, the string representation of the goal
    */
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}~{_description}~{_points}";
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        GetStringRepresentation();
        return _points;
    }
}