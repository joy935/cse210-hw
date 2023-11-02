using System;

/* Goal Base Class */
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    private List<SimpleGoal> _simpleGoals = new List<SimpleGoal>();

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract void CreateGoal();
    { }

    public virtual void ListGoal()
    {   
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
}