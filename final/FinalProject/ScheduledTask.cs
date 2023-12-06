using System;

/* ScheduledTask Derived Class */
public class ScheduledTask : Task
{
    // no attributes

    /* constructor of the class */
    public ScheduledTask(string taskType, string taskDescription, DateOnly dueDate, bool isCompleted) : base(taskType, taskDescription, dueDate, isCompleted)
    { }

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
            return $"ScheduledTask:{_taskDescription}~{_dueDate}~True";
        }
        else
        {
            return $"ScheduledTask:{_taskDescription}~{_dueDate}~False";
        }
    }

    /* DisplayTaskInfo is a method that displays the task info.
    Parameters: none
    Return: none
    */
    public override void DisplayTaskInfo()
    {
        if (_isCompleted == true)
        {
            Console.WriteLine($"✓ {_taskDescription} - Due: {_dueDate.ToLongDateString()}");
        }
        else
        {
            Console.WriteLine($"{_taskDescription} - Due: {_dueDate.ToLongDateString()}");
        }    
    }
}