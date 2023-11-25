using System;

/* RepetitiveTask Derived Class */
public class RepetitiveTask : Task
{
    /* attributes of the class */
    private int _frequencyRepetition;   // frequency of the task
    private DateTime _dueDate;          // first due date of the task
    private int _numberRepetition;      // number of times the task has been repeated
    private int _totalRepetition;       // total number of times the task should be repeated

    /* constructor of the class */
    public RepetitiveTask(string taskType, string taskDescription, bool isCompleted, int frequencyRepetition, DateTime dueDate, int numberRepetition, int totalRepetition) : base(taskType, taskDescription, isCompleted)
    {
        _frequencyRepetition = frequencyRepetition;
        _dueDate = dueDate;
        _numberRepetition = numberRepetition;
        _totalRepetition = totalRepetition;
    }

    /* Getters and setters for the attributes of the class */
    public int GetFrequencyRepetition()
    {
        return _frequencyRepetition;
    }
    public void SetFrequencyRepetition(int frequencyRepetition)
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

    
}