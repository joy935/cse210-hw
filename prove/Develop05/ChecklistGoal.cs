using System;

/* Checklist Goal derived class */
public class ChecklistGoal : Goal
{
    // attributes of the class
    private int _totalRepetition;   // the total number of times the goal needs to be accomplished for a bonus
    private int _bonus;             // the bonus points associated with the goal
    private int _numberRepetition;  // the number of times the goal has been accomplished

    /* ChecklistGoal is a constructor method used to initialize the fields 
    of the class using the base class constructor
    Parameters: string type, string name, string description, int points, 
    int bonus, int totalRepetition, int numberRepetition
    Return: none
    */
    public ChecklistGoal(string type, string name, string description, int points, int bonus, int totalRepetition, int numberRepetition) : base(type, name, description, points)
    {
        _bonus = bonus;
        _totalRepetition = totalRepetition;
        _numberRepetition = numberRepetition;
    }

    /* CreateGoal is a method that creates a new goal
    It overrides the CreateGoal method in the base class by
    asking the user for the bonus, total repetition, and number repetition
    on top of the goal type, name, description, and points
    It also initializes the number repetition to 0
    Parameters: none
    Return: none
    */
    public override void CreateGoal()
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
        _numberRepetition = 0;
    }

    /* ListGoals is a method that displays the goal in a list format
    It overrides the ListGoals method in the base class by adding a
    checkbox to indicate if the goal is completed or not
    and the number of times the goal has been accomplished out of the total
    Parameters: none
    Return: none
    */
    public override void ListGoals()
    {
        if (IsCompleted() == true)
        {
            Console.WriteLine($"[X] {_name} ({_description}) -- Currently completed: {_numberRepetition}/{_totalRepetition}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: {_numberRepetition}/{_totalRepetition}");
        }
    }

    /* GetStringRepresentation is a method that returns a string
    representation of the goal
    It overrides the GetStringRepresentation method in the base class
    by adding the bonus, total repetition, and number repetition
    on top of the goal type, name, description, and points attributes
    Parameters: none
    Return: string, the string representation of the goal
    */
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}~{_description}~{_points}~{_bonus}~{_totalRepetition}~{_numberRepetition}";
    }

    /* IsCompleted is a method that returns true if the goal is completed
    and false if the goal is not completed
    It overrides the IsCompleted method in the base class by returning
    true if the number repetition is a multiple of the total repetition
    and if the number repetition is not 0
    Parameters: none
    Return: bool, true if the goal is completed and false if the goal
    */    
    public override bool IsCompleted()
    {
        if (_numberRepetition % _totalRepetition == 0 && _numberRepetition != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /* RecordEvent is a method that records an event
    It overrides the RecordEvent method in the base class by adding the
    bonus points if the goal is totally completed and points if the goal
    is not partially completed
    Parameters: none
    Return: int, the number of points associated with the goal
    */
    public override int RecordEvent()
    {
        _numberRepetition++; // increment the number of repetition
        // if the goal is partially completed
        if (_numberRepetition < _totalRepetition)
        {
            GetStringRepresentation(); // update the string representation
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        // if the goal is totally completed
        else if (_numberRepetition == _totalRepetition)
        {
            _points +=_bonus;           // add the bonus points
            GetStringRepresentation();  // update the string representation
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        // if the goal is already completed
        else
        {
            // display an error message
            Console.WriteLine("Error: You have already completed this goal.");
            return 0; // return 0 points
        } 
    }
}