using System;

/* Goal Base Class */
public abstract class Goal          // abstract class because some methods are not instantiated
{
    // attributes of the class
    protected string _type;         // the type of the goal
    protected string _name;         // the name of the goal
    protected string _description;  // the description of the goal
    protected int _points;          // the points associated with the goal

    /* Goal is a constructor method that creates an instance of the Goal class.
    Parameters: string type, string name, string description, int points
    Return: none
    */
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }
    /* Getters and setters for the attributes of the class */
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

    /* CreateGoal is a virtual method that creates a new goal
    It has some implemmentation in the base class but it can be overriden in the derived classes
    Parameters: none
    Return: none
    */
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
    }

    /* ListGoals is an abstract method that lists the goals
    It has no implementation in the base class and it must be overriden 
    in the derived classes
    Parameters: none
    Return: none
    */
    public abstract void ListGoals();

    /* GetStringRepresentation is an abstract method that returns a string 
    representation of the goal
    It has no implementation in the base class and it must be overriden
    in the derived classes
    Parameters: none
    Return: string, the string representation of the goal
    */
    public abstract string GetStringRepresentation();

    /* IsCompleted is an abstract method that returns true if the goal 
    is completed and false if the goal is not completed
    It has no implementation in the base class and it must be overriden
    in the derived classes
    Parameters: none
    Return: bool, true if the goal is completed and false if the goal 
    is not completed
    */
    public abstract bool IsCompleted();

    /* RecordEvent is an abstract method that records an event
    It has no implementation in the base class and it must be overriden
    in the derived classes
    Parameters: none
    Return: int, the number of points associated with the goal
    */
    public abstract int RecordEvent();
}