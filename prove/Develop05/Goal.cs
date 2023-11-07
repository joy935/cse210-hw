using System;

/* Goal Base Class */
public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetGoalType()
    {
        return _type;
    }

    public void SetGoalType(string type)
    {
        _type = type;
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

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
    }

    public abstract void ListGoals();

    public abstract string GetStringRepresentation();

    public abstract bool IsCompleted();

    public abstract int RecordEvent();
}