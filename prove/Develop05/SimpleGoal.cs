using System;
using System.Diagnostics.Tracing;

/* Simple Goal derived class */
public class SimpleGoal : Goal
{
    // attribute of the class
    private bool _completed; // to store the completion status of the goal

    /* Simple goal is a constructor method used to initialize the fields of the class using the base class constructor
    Parameters: string type, string name, string description, int points, bool completed
    Return: none
    */
    public SimpleGoal(string type, string name, string description, int points, bool completed) : base(type, name, description, points)
    {
        _completed = completed;
    }

    /* ListGoals is a method that displays the goal in a list format
    It overrides the ListGoals method in the base class by adding a 
    checkbox to indicate if the goal is completed or not
    Parameters: none
    Return: none
    */
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

    /* GetStringRepresentation is a method that returns a string 
    representation of the goal
    It overrides the GetStringRepresentation method in the base class 
    by adding a boolean value to indicate if the goal is completed or not
    on top of the goal type, name, description, and points attributes
    Parameters: none
    Return: string, the string representation of the goal
    */
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

    /* IsCompleted is a method that returns true if the goal is completed
    and false if the goal is not completed
    It overrides the IsCompleted method in the base class by returning
    the value of the _completed field
    Parameters: none
    Return: bool, true if the goal is completed and false if the goal
    */
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

    /* RecordEvent is a method that records an event
    It overrides the RecordEvent method in the base class by displaying
    a message to the user, setting the _completed attribute to true, 
    calling the GetStringRepresentation to update the string and 
    returning the number of points earned
    Parameters: none
    Return: int, the number of points associated with the goal
    */
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _completed = true;
        GetStringRepresentation();
        return _points;
    }
}