using System;

/* Simple Goal derived class */
public class SimpleGoal : Goal
{
    private int _totalPoints;

    public SimpleGoal(string name, string description, int points, int totalPoints) : base(name, description, points)
    {
        _totalPoints = totalPoints;
    }

    public override string CreateGoal()
    {
        return $"{_name} ({_description})";
    }
}