using System;

/* RepetitiveTask Derived Class */
public class RepetitiveTask : Task
{
    /* attributes of the class */
    private string _frequencyRepetition;    // frequency of the task
    private int _numberRepetition;          // number of times the task has been repeated
    private int _totalRepetition;           // total number of times the task should be repeated

    /* constructor of the class */
    public RepetitiveTask(string taskType, string taskDescription, DateOnly dueDate, bool isCompleted, string frequencyRepetition, int numberRepetition, int totalRepetition) : base(taskType, taskDescription, dueDate, isCompleted)
    {
        _frequencyRepetition = frequencyRepetition;
        _numberRepetition = numberRepetition;
        _totalRepetition = totalRepetition;
    }

    /* Getters and setters for the attributes of the class */
    public string GetFrequencyRepetition()
    {
        return _frequencyRepetition;
    }
    public void SetFrequencyRepetition(string frequencyRepetition)
    {
        _frequencyRepetition = frequencyRepetition;
    }
    public DateOnly GetDueDate()
    {
        return _dueDate;
    }
    public void SetDueDate(DateOnly dueDate)
    {
        _dueDate = dueDate;
    }
    public int GetNumberRepetition()
    {
        return _numberRepetition;
    }
    public void SetNumberRepetition(int numberRepetition)
    {
        _numberRepetition = numberRepetition;
    }
    public int GetTotalRepetition()
    {
        return _totalRepetition;
    }
    public void SetTotalRepetition(int totalRepetition)
    {
        _totalRepetition = totalRepetition;
    }

    /* methods of the class */
    /* GetTaskInfo is a method that returns the task info
    in a specific format to be saved later in a file.
    If the task is completed, the method returns the task info
    with the isCompleted attribute set to true. Otherwise, it returns
    the task info with the isCompleted attribute set to false.
    Parameters: none
    Return: string
    */
    public override string GetTaskInfo()
    {
        if (_isCompleted == true)
        {
            return $"RepetitiveTask:{_taskDescription}~{_dueDate}~True~{_frequencyRepetition}~{_numberRepetition}~{_totalRepetition}";
        }
        else
        {
            return $"RepetitiveTask:{_taskDescription}~{_dueDate}~False~{_frequencyRepetition}~{_numberRepetition}~{_totalRepetition}";
        }
    }

    /* DisplayTaskInfo is a method that displays the task info.
    Parameters: none
    Return: none
    */
    public override void DisplayTaskInfo()
    {
        Console.WriteLine($"{_taskDescription} - Due: {_dueDate} (Repetition: {_numberRepetition}/{_totalRepetition})");
    }

    /**/
    public void UpdateDueDate()
    {
        switch (_frequencyRepetition)
        {
            case "daily":
                _dueDate = _dueDate.AddDays(1);
                Console.WriteLine(_dueDate);
                break;
            case "weekly":
                _dueDate = _dueDate.AddDays(7);
                Console.WriteLine(_dueDate);
                break;
            case "monthly":
                _dueDate = _dueDate.AddMonths(1);
                Console.WriteLine(_dueDate);
                break;
            case "yearly":
                _dueDate = _dueDate.AddYears(1);
                Console.WriteLine(_dueDate);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    /* MarkComplete is a method that marks the task as completed
    by incrementing the number of repetition. If the number of 
    repetition is less than the total number of repetition, the
    method returns false. Otherwise, it returns true.
    Parameters: none
    Return: bool
    */
    public override bool MarkComplete()
    {
        if (_numberRepetition < _totalRepetition)
        {
            _numberRepetition++;
            UpdateDueDate();
            if (_numberRepetition == _totalRepetition)
            {
                _isCompleted = true;
                return true;
            }
            else
            {
                _isCompleted = false;
                return false;
            }
        }
        else
        {
            _isCompleted = true;
            return true;
        }
    }
}
