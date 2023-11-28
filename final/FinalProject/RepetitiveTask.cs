using System;

/* RepetitiveTask Derived Class */
public class RepetitiveTask : Task
{
    /* attributes of the class */
    private string _frequencyRepetition;   // frequency of the task
    private DateTime _dueDate;          // first due date of the task
    private int _numberRepetition;      // number of times the task has been repeated
    private int _totalRepetition;       // total number of times the task should be repeated

    /* constructor of the class */
    public RepetitiveTask(string taskType, string taskDescription, bool isCompleted, string frequencyRepetition, DateTime dueDate, int numberRepetition, int totalRepetition) : base(taskType, taskDescription, isCompleted)
    {
        _frequencyRepetition = frequencyRepetition;
        _dueDate = dueDate;
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
    public DateTime GetDueDate()
    {
        return _dueDate;
    }
    public void SetDueDate(DateTime dueDate)
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

    /* GetTaskInfo ...
    */
    public override string GetTaskInfo()
    {
        if (_isCompleted == true)
        {
            return $"RepetitiveTask:{_taskDescription}~{_frequencyRepetition}~{_dueDate}~{_numberRepetition}~{_totalRepetition}~True";
        }
        else
        {
            return $"RepetitiveTask:{_taskDescription}~{_frequencyRepetition}~{_dueDate}~{_numberRepetition}~{_totalRepetition}~False";
        }
    }

    /* DisplayTaskInfo ...
    */
    public override void DisplayTaskInfo()
    {
        Console.WriteLine($"{_taskDescription} - Due: {_dueDate} (Repetition: {_numberRepetition}/{_totalRepetition})");
    }
}