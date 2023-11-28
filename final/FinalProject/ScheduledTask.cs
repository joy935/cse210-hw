using System;

/* ScheduledTask Derived Class */
public class ScheduledTask : Task
{
    /* attributes of the class */
    private DateOnly _dueDate; // due date of the task

    /* constructor of the class */
    public ScheduledTask(string taskType, string taskDescription, bool isCompleted, DateOnly dueDate) : base(taskType, taskDescription, isCompleted)
    {
        _dueDate = dueDate;
    }

    /* Getters and setters for the attributes of the class */
    public DateOnly GetDueDate()
    {
        return _dueDate;
    }
    public void SetDueDate(DateOnly dueDate)
    {
        _dueDate = dueDate;
    }

    /* GetTaskInfo ...
    */
    public override string GetTaskInfo()
    {
        if (_isCompleted == true)
        {
            return $"ScheduledTask:{_taskDescription}~{_dueDate}~True";
        }
        else
        {
            return $"ScheduledTask:{_taskDescription}~{_dueDate}~False";
        }
    }

    /* DisplayTaskInfo ...
    */
    public override void DisplayTaskInfo()
    {
        Console.WriteLine($"{_taskDescription} - Due: {_dueDate}");
    }
}